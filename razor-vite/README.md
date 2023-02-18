# Building a .NET Web API from scratch

These are the steps to build a .NET Web API solution using the dotnet CLI tooling.

Create a new solution using the following command:

> dotnet new sln -n labs

Create a new project using the following command:

> dotnet new webapi -n labs.api

Add the project to the solution using the following command:

> dotnet sln add labs.api

Create a new project using the following command:

> dotnet new classlib -n labs.core

Add the project to the solution using the following command:

> dotnet sln add labs.core

Create a new project using the following command:

> dotnet new xunit -n labs.tests

Add the project to the solution using the following command:

> dotnet sln add labs.tests

Add a reference to the core project from the API project using the following command:

> dotnet add labs.api reference labs.core

Add a reference to the core project from the tests project using the following command:

> dotnet add labs.tests reference labs.core

Add a reference to the API project from the tests project using the following command:

> dotnet add labs.tests reference labs.api

For front-end development, we will use a razor pages project. Create a new project using the following command:

> dotnet new webapp -n labs.ui

Add the project to the solution using the following command:

> dotnet sln add labs.ui

The Razor solution will communicate with the API using a RESTful API. The API is an OpenAPI specification, so a client proxy can be generated from the web API.  Typescript definitions can be generated from the OpenAPI specification.  The Typescript definitions can be used to create a strongly typed client proxy for the web API.  Generate the Typescript definitions using the following command:

> dotnet add labs.api package Swashbuckle.AspNetCore.SwaggerGen

> dotnet add labs.api package Swashbuckle.AspNetCore.SwaggerUI

> dotnet add labs.api package Swashbuckle.AspNetCore.Cli

> dotnet swagger tofile --output labs.api/swagger.json --host http://localhost:5000

> dotnet swagger tofile --output labs.ui/swagger.json --host http://localhost:5001

> dotnet add labs.ui package NSwag.CodeGeneration.TypeScript

> dotnet nswag swagger2tsclient /input:labs.ui/swagger.json /output:labs.ui/src/app/api-client.ts

Run tests using the following command:

> dotnet test

Run the API using the following command:

> dotnet run --project labs.ap

Install the openapi proxy generator using the following command:

> npm install openapi-typescript-codegen -g

Generate the typescript proxy using the following command:

> openapi -i http://localhost:5230/swagger/v1/swagger.json -o api

To begin development, open the solution in Visual Studio Code using the following command:

> code .

To run the API, open a terminal in Visual Studio Code and run the following command:

> dotnet run --project labs.api

To run the UI, open a terminal in Visual Studio Code and run the following command:

> dotnet run --project labs.ui

To run the tests, open a terminal in Visual Studio Code and run the following command:

> dotnet test

And here is a script which starts the API and UI projects:

    #!/bin/bash

    # Start the API
    dotnet run --project labs.api & 

    # Start the UI
    dotnet run --project labs.ui &

    # Wait for the user to press enter
    read -p "Press enter to continue"

    # Kill the API and UI processes
    kill $(jobs -p)

You can run the script using the following command:

> ./start.sh

But first, you will need to make the script executable using the following command:

> chmod +x start.sh

To transpile the Typescript code, open a terminal in Visual Studio Code and run the following command:

> npm run build

To run the Typescript code, open a terminal in Visual Studio Code and run the following command:

> npm run start

To run the Typescript code in watch mode, open a terminal in Visual Studio Code and run the following command:

> npm run watch

To run the Typescript code in debug mode, open a terminal in Visual Studio Code and run the following command:

> npm run debug

You must add the following scripts to package.json:

    "scripts": {
        "build": "tsc",
        "start": "tsc && node dist/index.js",
        "watch": "tsc && node dist/index.js",
        "debug": "tsc && node --inspect-brk dist/index.js"
    },

The vite project build artifacts are stored in the dist folder.  The dist folder is ignored by git.  To build the project, run the following command from that folder:

> npm run build

To change the default port, add the following to the package.json file:

    "vite": {
        "port": 5001
    },

To change the build directory from dist to wwwroot, add the following to the package.json file:

    "vite": {
        "build": {
            "outDir": "../wwwroot"
        }
    },

The vite build is stored in wwwroot/app so to allow vite to generate index.html with the proper href path you need to modify the vite.config.js file to include the following:

    export default {
        base: '/app/',
        build: {
        outDir: '../wwwroot/app',
        }
    }