# README File
This file has been added to attempt the pull request. These are the notes for github so far

# Github (Version Control)

![alt text](/Resources/Images/image-1.png)

To push your code to a github repo there are a few certain commands and steps we need to follow:
1. Git Add (From **Working Directory to Staging Area**)
2. Git Commit (From the **Staging Area** to the **local .git** file)
3. Git Push (From your **Local .git** file to the **Remote Repository**)

---

## Branch
By default there is only one branch, the **Main Branch**. <br> 

All the steps to follow from creating a remote repo, to initializaing the local git folder, to connecting them are:
1. Create a local folder that will host your git repository.
2. Open **git bash** and then cd into that folder.
3. Use the command "git init", this will initialize a local .**git file** that you will eventually use to connect to the remote repo.
4. Then once you do that add your files to the folder and then use the **git add .** command on the git bash terminal
5. Follow it with the **git commit -m "This is my first commit"** command.
6. Check using **git status** and it should say working branch is clean (or something).
7. On your github account create a new repository and click on the **green code button** and copy the hhtps link that looks something like **"https://github.com/Username/my_new_repo.git"**
8. Go to git bash and run the comman **git remote add origin "https://github.com/Username/my_new_repo.git"**
9. Once this is done, run the command **git push origin master** and it should push your files from local to your github repository

### Pulling from the git repo
In this specific scenario you have directly created a file inside your remote repository on github and commited the changes to the repository. <br>
Now you have to add those files to your local system (Assume that that file was added by someone else in your team)
