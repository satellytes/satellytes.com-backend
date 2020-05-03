# IoT for Satellytes Backend

This is an ongoing, evolutionary example project to demonstrate, integrate, test, improve an existing project with different technologies.
The use case of this example is a backend accepting information and processing information from IoT devices such as sensors for measuring temperature etc. The devices will send their information to the backend where the information will be store. The user can then access these informations via dashboard. Also there will be rest api to access some predefined calculated results. The project will run in AWS Cloud.

## Initial Version
The project setup is based on Spring Boot micro services. There will be a relational database to save the incoming data. All calls are synchronous and blocking. The micro services will run in Docker and EC2 / Fargate in AWS. The events from the IoT devices will be simulated at first. 

![inital version image](https://github.com/satellytes/satellytes.com-backend/blob/master/initial_version.PNG)

## Future versions:
- Reactive version of REST calls
- Authentication for clients and security for IoT
- Using DynamoDB instead of AWS RDS
- Use Kinesis as event streaming
- Use Eventsourcing and Streaming with Kinesis and DynamoDB
- Serverless with AWS Lambda / Kinesis, DynamoDB
- GraphQL for UI service
- AWS AppSync / AWS Amplify
- Dashboard for research
- Amazon MSK as event streaming
- .NET Core version of the project
- Use Micronaut instead of Spring Boot
- Kubernetes version
- Deployment Pipeline with Spinnaker
- Testing with Arquillian
- Additional services
- ...
