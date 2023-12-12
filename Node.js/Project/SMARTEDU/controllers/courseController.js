const Course = require('../models/Course');
const Category = require('../models/Category');
const User = require('../models/User');

exports.createCourse = async (req, res) => {
  try {
    const course = await Course.create({
      name: req.body.name,
      description: req.body.description,
      category: req.body.category,
      user: req.session.userID
    });

    req.flash("success", `${course.name} has been created successfully`);
    res.status(201).redirect('/courses');
  } catch (error) {
    req.flash("error", `Something happened!`);
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};

exports.getAllCourses = async (req, res) => {
  try {
    const categorySlug = req.query.categories;
    const query = req.query.search;

    const category = await Category.findOne({ slug: categorySlug });

    let filter = {};

    if (categorySlug) {
      filter.category = category._id;
    }

    if (query) {
      filter.name = { $regex: '.*' + query + '.*', $options: 'i' };
    }

    const courses = await Course.find(filter).sort('-createdAt').populate('user');
    const categories = await Category.find();

    res.status(200).render('courses', {
      courses,
      categories,
      page_name: 'courses',
    });
  } catch (error) {
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};


exports.getCourse = async (req, res) => {
  try {
    const user = await User.findById(req.session.userID);
    const course = await Course.findOne({slug: req.params.slug}).populate('user')
    const categories = await Category.find();

    res.status(200).render('course', {
      course,
      page_name: 'courses',
      user,
      categories, 
    });
  } catch (error) {
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};


exports.enrollCourse = async (req, res) => {
  try {
    const user = await User.findByIdAndUpdate(
      req.session.userID,
      { $push: { courses: req.body.course_id } },
      { new: true }
    );

    if (!user) {
      return res.status(404).json({ status: 'fail', message: 'User not found' });
    }

    res.status(200).redirect('/users/dashboard');
  } catch (error) {
    res.status(400).json({ status: 'fail', error: error.message });
  }
};

exports.releaseCourse = async (req, res) => {
  try {    
    const user = await User.findById(req.session.userID);

    // Öğrencinin derslerinden çıkarma işlemi
    await user.courses.pull(req.body.course_id);
    await user.save();

    res.status(200).redirect('/users/dashboard');
  } catch (error) {
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};

exports.deleteCourse = async (req, res) => {
  try {
    const course = await Course.findOneAndDelete({ slug: req.params.slug });

    if (!course) {
      req.flash('error', 'Course not found');
      return res.status(404).redirect('/users/dashboard');
    }

    req.flash('success', `${course.name} has been removed successfully`);
    res.status(200).redirect('/users/dashboard');
  } catch (error) {
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};

exports.updateCourse = async (req, res) => {
  try {    
    const course = await Course.findOne({ slug: req.params.slug });

    if (!course) {
      req.flash('error', 'Course not found');
      return res.status(404).redirect('/users/dashboard');
    }

    course.name = req.body.name;
    course.description = req.body.description;
    course.category = req.body.category;

    await course.save();
   
    req.flash('success', `${course.name} has been updated successfully`);
    res.status(200).redirect('/users/dashboard');

  } catch (error) {
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};
