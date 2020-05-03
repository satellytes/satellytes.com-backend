# IoT for Satellytes Backend

This is an ongoing, evolutionary example project to demonstrate, integrate, test, improve an existing project with different technologies.
The use case of this example is a backend accepting information and processing information from IoT devices such as sensors for measuring temperature etc. The devices will send their information to the backend where the information will be store. The user can then access these informations via dashboard. Also there will be rest api to access some calculated results from these informations. The project will run in AWS Cloud.

## Initial Version
The project setup is based on Spring Boot micro services. There will be a relational database to save the incoming data. All calls are synchronous and blocking. The micro services will run in Docker and EC2 / Fargate in AWS

![inital version image](https://github.com/satellytes/satellytes.com-backend/blob/master/initial_version.PNG)

## Future versions:
- Using DynamoDB instead of AWS RDS
- Use Kinesis as event streaming
- Use Eventsourcing and Streaming with Kinesis and DynamoDB
- Serverless with AWS Lambda / Kinesis, DynamoDB
- AWS AppSync / AWS Amplify
- Amazon MSK as event streaming
- .NET Core version of the project
- Use Micronaut instead of Spring Boot
- Kubernetes version
- Deployment Pipeline with Spinnaker
- ...
