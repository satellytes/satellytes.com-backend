using Amazon.CDK;
using Amazon.CDK.AWS.EC2;
using Amazon.CDK.AWS.ECS;
using Amazon.CDK.AWS.ECS.Patterns;
using Amazon.CDK.AWS.IAM;
using Amazon.CDK.AWS.ECR;

namespace CdkFargate
{
    public class CdkFargateStack : Stack
    {
        internal CdkFargateStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var vpc = new Vpc(this, "SatellytesVpc", new VpcProps
            {
                Cidr = "10.0.0.0/16",
                MaxAzs = 1,
                SubnetConfiguration = new[]{
                    new SubnetConfiguration(){
                        Name="Satellytes/public",
                        SubnetType = SubnetType.PUBLIC,
                    
                    

                    }
                },



    
            });

            var cluster = new Cluster(this, "SatellytesCluster", new ClusterProps
            {
                Vpc = vpc,


            });

            var taskDefinition = new TaskDefinition(this, "SatellytesWebTask", new TaskDefinitionProps{
                TaskRole = Role.FromRoleArn(this, "taskRole", "arn:aws:iam::576853867587:role/ecsTaskExecutionRole", new FromRoleArnOptions(){
                            Mutable = false
                        }),
                ExecutionRole = Role.FromRoleArn(this, "taskExecutionRole", "arn:aws:iam::576853867587:role/ecsTaskExecutionRole", new FromRoleArnOptions(){
                            Mutable = false
                        }),
                        Compatibility = Compatibility.FARGATE,
                        Cpu = "256",
                        MemoryMiB = "512",
                    

                        
            });

            var inboundSecurityGrp = new SecurityGroup(this, "satellytesSecurityGrpInboundInet", new SecurityGroupProps{
               Vpc = vpc 
            });

            inboundSecurityGrp.AddIngressRule(Peer.AnyIpv4(), Port.Tcp(8080), "inbound http");

            

            taskDefinition.AddContainer("satellytesWebImage", new ContainerDefinitionProps{
                Image = ContainerImage.FromEcrRepository(Repository.FromRepositoryName(this, "repo", "satellytes-website/backend"), "1cfb651f73fcd20895fc44c06f7bb180ca0e8322"),
                
                
            });

            new FargateService(this, "SatellytesWebService", new FargateServiceProps{
                Cluster = cluster,
                TaskDefinition = taskDefinition,
                VpcSubnets = new SubnetSelection{
                    SubnetType = SubnetType.PUBLIC
                },
                AssignPublicIp = true,


            });
         
        }
    }
}
