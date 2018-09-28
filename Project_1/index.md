---
Title: Homework #1 Html, Bootstrap, CSS, GIT
---

Git commands:
The git commands are the basic tools in order to link a repository between github or bitbucket so these tools are the most crucial parts to setup. 

1. Build the respoitory in your github or bitbucket. Then install git bash if you did not have already installed.

So in the first step you are mostly setting up your repository you will also need a folder on your local server or computer for that repository to link into. Here's how that is done:

2. When build the the link remember to use git bash and follow these steps below to setup the remote repository link.

Note: make sure you are in the designated folder you want your repository to link into. If you did not make a folder then build one and link that folder to that location.

git remote add -url:
This is specifcally the command to create remote repository between your local machine and the online repository in either github or bitbucket.

git init: initsalizes the git command functions.
Note: you only have to initalize the git once!

git status: checks if any files have been modified.

git add: initalizes the files to be in a commit stage.
Note: all == add all files as well as "."

git commit -m: is where you will commit the files to be loaded into the repsoitory. Note: -m is just asking you to write a comment about this commit stay consistent with your ("").

git push -u: you are pushing the files you have commited into your local repository and -u is traking it. note the first you do this it will be using the (origin master), which is the origin of the repository link 

```bash
cd desktop/CS_460
mkdir Dakota808.github.io
git init
git remote add https://github.com/Dakota808/Dakota808.github.io.git
```
Here is an example of the git commit, status, add, and push:

```bash

```