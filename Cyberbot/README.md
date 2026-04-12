#  Cybersecurity Awareness Chatbot (PROG6221 Part 1)

##  Overview

This project is a **C# Console Application** developed for PROG6221.
It is a **Cybersecurity Awareness Chatbot** designed to educate South African users about online safety.

The chatbot interacts with users in a conversational way and provides guidance on topics such as:

* Phishing scams
* Password security
* Safe browsing practices


##  Purpose

The goal of this chatbot is to:

* Raise awareness about cybersecurity threats in South Africa 🇿🇦
* Help users identify scams and unsafe online behaviour
* Simulate real-world cyber threat scenarios


##  Features

✔ Voice greeting using a `.wav` file
✔ ASCII art title screen
✔ Personalised user interaction
✔ Cybersecurity-related responses
✔ Input validation for user entries
✔ Enhanced console UI (colors + typing effect)
✔ Structured code using multiple classes



##  Project Structure

```
CyberBot/
│
├── Program.cs        // Main entry point
├── Chatbot.cs        // Chatbot logic and responses
├── User.cs           // Stores user information
├── AudioPlayer.cs    // Handles voice playback
├── greeting.wav      // Voice greeting file
```


## ▶️ How to Run the Program

###  Requirements

* Microsoft Visual Studio (recommended)
* .NET 6 or later


###  Steps

1. Open the project in Visual Studio
2. Ensure `greeting.wav` is included in the project
3. Set file property:

   ```
   Copy to Output Directory → Copy if newer
   ```
4. Click Start to run the program

---

##  Audio Feature

The chatbot plays a voice greeting at startup using a `.wav` file.


##  Example Questions You Can Ask

* "How are you?"
* "What is your purpose?"
* "What is phishing?"
* "How do I create a strong password?"
* "What is safe browsing?"



## Technologies Used

* C#
* .NET Console Application
* System.Media (for audio playback)



##  GitHub & Version Control

This project is managed using GitHub with:

* Minimum of 6 commits
* Meaningful commit messages
* Continuous Integration (CI) using GitHub Actions



##  CI Workflow

A GitHub Actions workflow is configured to:

* Build the project automatically
* Check for errors on every push



##  Video Presentation

A full video demonstration of this project is available here:

 *(Insert your unlisted YouTube link here)*

The video includes:

* Program demonstration
* Code explanation
* Logic walkthrough



  Author

* Student Name: Abulele Nkabi
* Module: PROG6221



 References

Pieterse, H. (2021). *The Cyber Threat Landscape in South Africa: A 10-Year Review.*
Available online: https://www.scielo.org.za


NB!

This chatbot is for educational purposes only and does not provide real-time cybersecurity protection.