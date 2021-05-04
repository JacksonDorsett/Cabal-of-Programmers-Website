#!/bin/bash
echo "enter commit message:"
read msg
git add -A
git commit -m "$msg"
git push
echo "push complete"
