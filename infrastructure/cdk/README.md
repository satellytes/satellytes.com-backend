# CDK Project for setting up the AWS Infrastructure

Currently the process sets up a single fargate task with a service in a public vpc.

To execute the deployment you have to install the following prerequisites
- .NET Core 3.1
- Node.js
- AWS CDK
A good guide to getting started is here: https://docs.aws.amazon.com/cdk/latest/guide/getting_started.html

To do the deployment you have to store the credentials to access aws in a profile. For this navigate to your user directory (windows etc. c:\users\username\.aws) and create a file named config with the following contents

[profile prod]  
aws_access_key_id=<Access_key>  
aws_secret_access_key=<secret_key>  
region=us-east-2  

# Steps
- Switch to the root folder of the cdk project
- Execute dotnet build src for compiling the project
- Execute cdk synth
- Execute cdk deploy --profile prod

To destroy the current infrastructure execute:
cdk destroy --profile prod