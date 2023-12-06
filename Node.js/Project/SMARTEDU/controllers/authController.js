const User = require('../models/User');
const bcrypt = require('bcrypt');
const Category = require('../models/Category');
exports.createUser = async (req, res) => {
  try {
    const user = await User.create(req.body);

    res.status(201).redirect('/login');
  } catch (error) {
    res.status(400).json({
      status: 'fail',
      error,
    });
  }
};

exports.loginUser = async (req, res) => {
  try {
    const { email, password } = req.body;

    const user = await User.findOne({ email });

    if (user) {
      bcrypt.compare(password, user.password, (err, same) => {
        if (same) {
          // USER SESSION
          req.session.userID = user._id;
          res.status(200).redirect('/');
        } else {
          res.status(401).send("Invalid password");
        }
      });
    } else {
      res.status(404).send("User not found");
    }
  } catch (error) {
    res.status(500).json({
      status: 'error',
      error: error.message,
    });
  }
};

exports.logoutUser = (req, res) => {
  req.session.destroy(()=> {
    res.redirect('/');
  })
}

exports.getDashboardPage = async (req, res) => {
  const user = await User.findOne({_id:req.session.userID})
  const categories = await Category.find();
  res.status(200).render('dashboard', {
    page_name: 'dashboard',
    user,
    categories
  });
};