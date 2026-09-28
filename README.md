# Development Workflow

This repository uses branches and pull requests to review changes before they become part of `main`. If you are new to Git, follow the steps below for each task. The key habit is: **do your work on your own branch and open a pull request—do not push directly to `main`.**

## Why we use branches and pull requests

A branch gives you a separate place to work without changing the shared `main` branch. A pull request (PR) lets teammates review your changes, discuss them, and run any needed checks before they are merged. This helps everyone see what is changing and reduces the chance of accidentally disrupting other work.

Treat `main` as the team's shared, reviewed version of the project. Even if Git allows you to push directly to it, don't. Make working through a branch and PR your normal routine.

## One-time setup

If you have not downloaded the repository to your computer yet, clone it using the remote repository URL:

```bash
git clone https://github.com/jlantz804/software_engineering_project.git
cd software_engineering_project
```

If you already have a local copy, open a terminal in the repository folder. You can check that you are in the right place with:

```bash
git status
```

## Workflow for each task

### 1. Start from the latest `main`

Before beginning a task, switch to `main` and get the latest shared changes:

```bash
git switch main
git pull origin main
```

If Git reports that you have uncommitted changes, pause and resolve or save that work before switching branches. Do not discard changes you still need.

### 2. Create a branch for your task

Use a short, descriptive name that says what you are working on. Prefixes such as `feature/`, `fix/`, or `docs/` can make branches easier to scan:

```bash
git switch -c feature/describe-your-change
```

For example:

```bash
git switch -c fix/login-validation
```

Keep each branch focused on one task. If you begin a different task, create a separate branch for it.

### 3. Make and check your changes

Edit the project files for your task, then review what Git sees:

```bash
git status
git diff
```

`git status` shows which files have changed. `git diff` shows the actual edits. Run the project's relevant tests or checks before sharing your work. Do not include unrelated changes or secrets such as passwords, tokens, or private keys.

### 4. Commit your changes on your branch

Stage only the files you intend to include. Replace the example paths below with your changed file names:

```bash
git add path/to/changed-file
git commit -m "Describe the change"
```

A commit is a saved checkpoint of your work. Write a brief message that explains what the commit changes. If you have several related changes, you can make more than one commit.

### 5. Push your branch—not `main`

Publish your branch to the shared repository so teammates can see it:

```bash
git push -u origin feature/describe-your-change
```

Use the name of your branch in place of `feature/describe-your-change`. The `-u` option connects your local branch to the remote branch, so later updates can usually be pushed with `git push`.

**Before pushing, check your current branch with `git branch --show-current`. It should show your task branch, not `main`.**

### 6. Open a pull request

On the repository's hosting site, create a pull request with:

- **Base branch:** `main`
- **Compare branch:** your task branch

Describe what changed, why it changed, and how you tested it. Add relevant context for reviewers, respond to feedback, and make any requested updates on the same branch. New commits pushed to that branch will appear in the pull request.

Wait for the required reviews and checks before merging. Follow the team's process if a reviewer or check identifies an issue.

### 7. Clean up after the PR is merged

Once the pull request is merged, update your local `main` before starting the next task:

```bash
git switch main
git pull origin main
```

You can then create a fresh branch for your next task.

## If something goes wrong

Git commands can behave differently depending on your current branch and whether you have uncommitted work. When unsure, start with:

```bash
git status
git branch --show-current
```

Read the output before running more commands. If you are unsure how to recover, ask a teammate for help rather than deleting changes or pushing to `main` to get around a problem.
