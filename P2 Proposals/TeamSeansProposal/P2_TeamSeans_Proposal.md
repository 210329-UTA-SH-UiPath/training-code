# Automatic Git Pull Manager

Authors: Jeffery Breiner, Nick Nevius, Sean Lee, Sean Spring

## Overview
Have you ever wanted to start working on your own branch just to find out it’s not up to date, and then spend the next 20 minutes updating your local repository and solving merge conflicts? Fortunately, we can use automation to reduce all that tedium and let you focus on doing real development. 

## About
We can use automation to check the upstream repository for new commits and then update your local repository synchronized while allowing the user to solve merge conflicts before pushing to your forked repository to keep everything up to date. 

### Goals:
- Create a UiPath robot that will use Windows and a web browser to check a github repo for new commits.
- The robot can update the local repository via Git bash or possibly Visual Studio Code. If there are merge conflicts, the robot can stop and email the user the issue or auto solve the - conflict to the user’s preference.
- If the robot successfully updates the local repo, it can push the changes to the fork and then email the user that the local repo is up to date with the original repository.
- Ideally, it will be able to be scheduled to execute at a specific interval or whenever  prompted by the user

### Qualifications: 
- We’re currently undergoing UiPath’s own certified training course, and will be RPA experts in the coming weeks.
- We have been managing Git repositories on Github for 5.5 weeks as of now,

## Why
We think it’s important to speed up the mundane, and automating the branch update process will reduce time dedicated to chores and free up time for creative development and learning. It is best to catch issues such as merge conflicts sooner rather than later because they become increasingly annoying to deal with as they pile up.

## Flow Chart

![Credentials Setup Flow Chart Diagram](https://github.com/sspring963/training-code/tree/main/P2%20Proposals/TeamSeansProposal/ProposalSetup.png)












