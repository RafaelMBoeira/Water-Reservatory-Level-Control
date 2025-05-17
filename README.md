# Water Reservatory Level Control with Arduino

## Goal
  * This is a project I originally developed in high school as part of a mandatory internship for my electronics course.
    Back then, I didn’t know anything about data structures or object-oriented programming, so most of the code is pretty bad
     — very limited, lots of repetition, poor and inconsistent naming (though thankfully, most of the logic still works). With that in mind,
    I’m going to refactor everything that needs fixing and maybe even add some new features (probably not).

## Description
  * The application is basically an IDE for control and monitoring of a FESTO water level bench using an Arduino. However, it’s designed for users
    who aren’t expected to know anything about programming (aside from basic math operators and the idea of sequential execution). The original goal of
    the project was to show the students from the electromechanics course how different types of control (Proportional, Integral, Derivative, etc...)
    affects the level of water and display any relevant variables in real time.

## Features
  * Create, edit, save and load programs;
  * Compile and load .ino files (executing .bat via C#);
  * Serial communication;
  * Select and Display data from Arduino in a Chart;
  * Save collected data to a .csv file. 