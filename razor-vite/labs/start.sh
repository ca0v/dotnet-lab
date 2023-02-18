#!/bin/bash

# kill process running on port 5230 on iOS
lsof -ti:5230 | xargs kill
lsof -ti:5231 | xargs kill

# Start the API
dotnet watch --project labs.api & 

# Start the UI
dotnet watch --project labs.ui &

# Wait for the user to press enter
read -p "Press enter to continue"

# Kill the API and UI processes
kill $(jobs -p)

# Exit the script
exit 0

