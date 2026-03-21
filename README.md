# Git Rules (Simple Version)
## 1. Branches
- Main branch: Always stable. Only tested and working code goes here.
- Dev branch: Used to combine new features before they go to main.
- Feature branches: Each member works on their own task here.
- Naming: <type>/<module>-<short-description>
  - Example: feature/task-add-priority
## 2. Branching Rules
- Always start a new feature branch from dev.
- Never push code directly to main.
- Merge to dev using a Pull Request (PR) only.
## 3. Commits
- Format: [Module] short description
- Example: [ReadingLog] Fix status update bug
- Commit often, small changes are better.
- Try to make one PR per feature if possible.
## 4. Pull Requests (PR)
- Title: [Module] short description
- Add a short explanation of what changed.
- PR must be reviewed by the tech lead or 2 teammates before merging.
- Fix any conflicts before merging.
## 5. Code Style
- Follow proper naming rules for classes, variables, and methods.
- Don’t push compiled files or folders like .vs, bin/, obj/. Add them to .gitignore.
## 6. Working with Code
- Always pull the latest version before you start working.
- Test your code locally before pushing or making a PR.
