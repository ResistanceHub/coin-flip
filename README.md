# Coin Flip

![Scheme](https://d30y9cdsu7xlg0.cloudfront.net/png/98997-200.png)

## Step 1: Flip The Coin

Open this solution and modify it so that it simulates flipping a coin 1000 times, and then prints out how many times it landed on heads and how many times it landed on tails.

The output should be similar to this:
```
The results are:
Heads: 200
Tails: 800
```

You can either simulate flipping 1 coin 1000 times or flip 1000 coins once. It depends on how you want to solve this problem.

If this confuses you, just flip 1 coin 1000 times 😝

### Clone This Repo

Open git bash from the Windows start menu.

Within git bash, change directory into your 'dev' or 'src' directory, or where ever you keep all your projects.

```
cd /c/src
```
or
```
cd /c/dev
```

Now clone the repo:

```
git clone https://YOUR-BITBUCKET-USERNAME@bitbucket.org/hubbledevelopment/coin-flip.git
```

If you are lucky enough to see the over tab on repos, you can copy the URL from here: https://bitbucket.org/hubbledevelopment/coin-flip/overview

Then use:
```
git clone url
```

Then go into the coin-flip directory in git bash.

```
cd coin-flip
```

At this stage you should see this on git bash:

```
/c/src/CoinFlip (master)
```

Make sure you see `(master)`. This means that all is good so far 👍

Next make a branch and push it! Do it! Just branch and push!

### Branching

You should do your work in a branch. Even before starting you can make a branch and push it.

Choose a branch name, you might want to use your initials so that the branch is unique e.g. `dh/flipping-coins`

To make a branch use git bash and type:

```
git checkout -b YOUR-BRANCH
```
e.g.
```
git checkout -b dh/flipping-coins
```

Then push it to bitbucket

```
git push -u origin YOUR-BRANCH
```

e.g.

```
git push -u origin dh/flipping-coins
```

Shortcut (this does the same thing):
```
git push -u origin HEAD
```

Use `-u` to setup a `upstream branch`. From this point on you only need `git push` and `git pull` - you don't need to specify the branch anymore.

Interestingly, this branch does not show up in bitbucket under branches at this location: https://bitbucket.org/hubbledevelopment/coin-flip/branches/

It is possible that that is a bug in bitbucket. However if you go to source - https://bitbucket.org/hubbledevelopment/coin-flip/src/master/

Then you should be able to select your branch from the dropdown. If you can see this, then you are all good 👍

### Running the solution

Next change into the coin-flip directory, if you are not already in that directory, and then open the solution file. You do this from the command line with:

```
cd coin-flip
start CoinFlip.sln
```

If you prefer, you can use Windows Exporer to open CoinFlip.sln. Just browse to the folder and double-click CoinFlip.sln. To open the current directory from the command line type:

```
explorer .
```

Once this is open in Visual Studio, click the green run button. You should see some output. This is just to help you get started. You will need to change it to complete the challenge.


### The Git Dance

As you are working, remember to commit your changes every 5 minutes or so:

```
git add .
git commit -m "A MESSAGE"
git push
```

Let us know on slack if you manager to make some progress, or if you need some help...

## Step 2: Save the Results

After once you have collected the results from flippnig the coin 1000 times, write these results to a text file. 

Note: if you don't give the file a path it will most likely creat this file in the `bin/debug` directory. This is a directory inside `coin-flip`. This is not a problem, just look for it the nested folder instead of the base directory `coin-flip`.

# Good luck! 
