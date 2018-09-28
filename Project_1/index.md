
# Homework #1 <br/> 
Html, Bootstrap, CSS, GIT<br/>
Here are links to my Repsoitory and my demo of my html pages:

[Repository](https://github.com/Dakota808/Dakota808.github.io/tree/master/Project_1)
[Demo](https://dakota808.github.io/Project_1/index.html)
[Main Page](https://dakota808.github.io/)


##Git commands:
The git commands are the basic tools in order to link a repository between github or bitbucket so these tools are the most crucial parts to setup. 

1. Build the respoitory in your github or bitbucket. Then install git bash if you did not have already installed.

So in the first step you are mostly setting up your repository you will also need a folder on your local server or computer for that repository to link into. Here's how that is done:

2. When build the the link remember to use git bash and follow these steps below to setup the remote repository link.

Note: make sure you are in the designated folder you want your repository to link into. If you did not make a folder then build one and link that folder to that location.

### git remote add -url:
This is specifcally the command to create remote repository between your local machine and the online repository in either github or bitbucket.

### git init: initsalizes the git command functions.
Note: you only have to initalize the git once!

### git status: checks if any files have been modified.

### git add: initalizes the files to be in a commit stage.
Note: all == add all files as well as "."

### git commit -m: 
Is where you will commit the files to be loaded into the repsoitory. Note: -m is just asking you to write a comment about this commit stay consistent with your ("").

### git push -u: 
You are pushing the files you have commited into your local repository and -u is traking it. note the first you do this it will be using the (origin master), which is the origin of the repository link 

### git log:
This displays all of the commits made to the repository.

``` bash
cd desktop/CS_460
mkdir Dakota808.github.io
git init
git remote add https://github.com/Dakota808/Dakota808.github.io.git
```
Here is an example of the git commit, status, add, and push:

``` bash
$ git status
On branch master
Your branch is up to date with 'origin/master'.

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git checkout -- <file>..." to discard changes in working directory)

        modified:   Project_1/index.md

$ git add --all

$ git commit -m"sample run of git commands"
[master 57fc9bd] sample run of git commands
 1 file changed, 18 insertions(+)

 $ git status
On branch master
Your branch is ahead of 'origin/master' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

 git push -u origin master
Counting objects: 4, done.
Delta compression using up to 4 threads.
Compressing objects: 100% (4/4), done.
Writing objects: 100% (4/4), 853 bytes | 426.00 KiB/s, done.
Total 4 (delta 3), reused 0 (delta 0)
remote: Resolving deltas: 100% (3/3), completed with 3 local objects.
To https://github.com/Dakota808/Dakota808.github.io.git
   f7f358a..57fc9bd  master -> master
Branch 'master' set up to track remote branch 'master' from 'origin'.

```

3. Build the Webpages:

Building a basic webpage is simple once you get the general basics of html. As well as how to add and apply a css style sheet. But I think the difficult part has to be how to setup the bootstrap and css.

The big issue is trying to set the navbar up in my html it would either look really odd where the links would stack on top of each other for some reason. But once I solved it for one page the rest were basically the same way. So my thought of this was just make a div to hows all of the different links and use a unorder list. However, that is not the case in fact you have to set the type of links inside of the "<nav>" config where each of the different links are going to be held so that they will line up instead of being stacked on each other. This is the same process for the other webpages.

``` html

<body>
        <nav class="navbar navbar-expand">  
            <div class="container-fluid space">
                <ul class="nav nav-tabs">                
                    <ul class="navbar-nav">
                        <li class="nav-item">
                            <a href="index.html">Home</a>
                        </li>
                    
                        <li class="nav-item">
                            <a href="AnimeList.html">Anime</a>

                        </li>

                        <li class="nav-item">
                            <a class="nav-Link"  href="J-Music.html">J-Music</a>
                        </li>
                    </ul>
                </ul>
            </div>
        </nav> 
    </body>


```

Bootstrap is just a way to make your html file look better by adding different styles and formats to different pieces inside of the html. However, we can honestly make our own style sheet by using a css file to link to the html file.

``` html
    <!---This is basic Bootstrap-->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!--My version of Bootstap-->
    <link rel="stylesheet" href="Stylesheet.css">
```

Note: that this is done while the css file is located in the same folder as the html for my version of a css style sheet while bootstraps is the default type and you can add styles into the html file directly.

Building a CSS
So when you build the css file note that this is a way customize your html page from background colors to how your text looks even perhaps you want to sent an image as your background.

Ex1.

``` css
.music{
    background-image: url("Owari_no_seraph_wallpaper.jpg");
    background-repeat: no-repeat;
    background-attachment: fixed;
    background-position: center;
    background-size: 1550px;
    
}
```
Ex2.

This is my setup for the nav bar as well how far each link is from each other. As well as the background color of the nav bar.

``` css
nav{
    background-color: white;
}
.nav-item{
    padding: 10px;
}
```

Then when adding a images I noticed that when two images a placed on the same html link they tend to overlap one another. so the work around for this was adding <div> to each specific image and making sure that those images are using a border where they will not crossover one another. 

``` html 
   <!--This is my usage of images and adjusting the positions-->
    <!--the image so that when -->
    <div class="row">

        <div class="col-md-6">
            <div class="container">
                <div class="anime">
                    <img src="Servamp.png" alt="Servamp Anime" style="width:700px;height:400px;">
                </div>
            </div>
        </div>
        <div class="col-md-6">
                <div class="container">
                    <div class="anime">
                    <img src="Owari_no_seraph_wallpaper.jpg" alt="Servamp Anime" style="width:700px;height:400px;">
                    </div>
                </div>
            </div>
    </div>

``` 

Finally building the list and table they are simple in nature of what I wanted to use them for. If you want to learn more on how to use these here are some simple links to show how to write them in html. As well as adding in links to differnet sites as well.
Have fun! 
[Tables](https://www.w3schools.com/html/html_tables.asp)
[List](https://www.w3schools.com/html/html_lists.asp)
[Links](https://www.w3schools.com/html/html_links.asp)

Ex. Tables
```html
<!--This a table desgined to show a list Music groups-->
        <div class="border">
            <table class="Artist">
            <tr>
                <th>Band</th>
                <th>Origin</th>
                <th>Genres</th>
                
            </tr>
            <tr>
                <td>One ok Rock</td>
                <td>Tokyo, Japan (2005)</td>
                <td>Post-Hardcore</td>
            </tr>
            <tr>
                <td>Uverworld</td>
                <td>Kusatsu, Shiga Prefecture, Japan (2000)</td>
                <td>Pop Rock</td>
            </tr>
            <tr>
                <td>Spyair</td>
                <td>Nagoya, Aichi Prefecture, Japan (2005)</td>
                <td>Alternative Rock</td>
            </tr>
            <tr>
                <td>My First Story</td>
                <td>Shibuya, Tokyo, Japan (2011)</td>
                <td>Alternative Rock</td>
            </tr>
            </table>
        </div>
```
Ex. Unorder List/Links
```html
 <nav class="navbar navbar-expand sites"> 
            <div class="links">
                <ul class="nav-tabs"> 
                    <li class="nav-item">
                        <a href="https://www.last.fm/tag/j-rock/artists">last.fm</a>

                    </li>
                
                    <li class="nav-item">
                        <a href="http://www.youtube.com">Youtube</a>

                    </li>

                    <li class="nav-item">
                        <a class="nav-Link"  href="https://www.ranker.com/list/japanese-rock-bands-and-artists/reference">download</a>
                     </li>
                </ul>
            </div>
        </nav>
```
Ex. Order List
```html
<div class="list">
            <p>
                <br>Here is a list of anime that I would recommend people<br>
                    to watch. This is my top ten Animes to watch.<br>
            </p>
           <div class="showlist"> 
               <ol>
                <li>Gundam 00</li>
                <li>Mahouka Koukou no Rettousei</li>
                <li>Gundam Build Divers</li>
                <li>Miira no Kaikata</li>
                <li>Gamers!</li>
                <li>Arpeggio of Blue Steel</li>
                <li>Infinite Stratos</li>
                <li>Mahoutsukai no Yome</li>
                <li>Gundam Build Try</li>
                <li>Gakuen Babysitter</li>
                </ol>
            </div>
        </div>
```
