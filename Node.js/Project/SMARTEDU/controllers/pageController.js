const nodemailer = require("nodemailer");
const Course = require('../models/Course');
const User = require('../models/User');


exports.getIndexPage = async (req, res) => {
  
  const courses = await Course.find().sort('-createdAt').limit(2);
  const totalCourses = await Course.find().countDocuments();
  const totalStudents = await User.countDocuments({role: 'student'});
  const totalTeachers = await User.countDocuments({role: 'teacher'});

  res.status(200).render('index', {
    page_name: 'index',
    courses,
    totalCourses,
    totalStudents,
    totalTeachers
  });
};

exports.getAboutPage = (req, res) => {
  res.status(200).render('about', {
    page_name: 'about',
  });
};

exports.getRegisterPage = (req, res) => {
  res.status(200).render('register', {
    page_name: 'register',
  });
};

exports.getLoginPage = (req, res) => {
  res.status(200).render('login', {
    page_name: 'login',
  });
};

exports.getContactPage = (req, res) => {
  res.status(200).render('contact', {
    page_name: 'contact',
  });
};


exports.sendEmail = async (req, res) => {

  try{

  const outputMessage = `
  
  <h1>Mail Details </h1>
  <ul>
    <li>Name: ${req.body.name}</li>
    <li>Email: ${req.body.email}</li>
  </ul>
  <h1>Message</h1>
  <p>${req.body.message}</p>
  `
  let transporter = nodemailer.createTransport({
      host: 'smtp.ethereal.email',
      port: 587,
      secure: true,
      auth: {
          user: 'sim.predovic10@ethereal.email',
          pass: 'HyTMgCx3DQCDzWVUQm'
      }
  });
    
    let info = await transporter.sendMail({
      from: '"Smart EDU Contact Form" <sim.predovic10@ethereal.email>', // sender address
      to: "lewiswolff88@gmail.com", // list of receivers
      subject: "Smart EDU Contact Form New Message", // Subject line
      html: outputMessage, // html body
    });
    console.log("Message sent: %s", info.messageId);
    console.log("Preview URL: %s", nodemailer.getTestMessageUrl(info));

    req.flash("success", "We Received your message succesfully");

    res.status(200).redirect('contact');
  } catch (err) {
    req.flash("error", `Something happened!`);
    res.status(200).redirect('contact');
  }
}