resource "aws_ecs_cluster" "satellytes-cluster" {
  name = "satellytes-cluster"
}

module "td" {
  source                       = "cn-terraform/ecs-fargate-task-definition/aws"
  version                      = "1.0.8"
  name_preffix                 = "satellytes"
  region                       = var.aws_region
  profile                      = "satellytes"
  container_name               = "satellytes-main"
  container_image              = "576853867587.dkr.ecr.us-east-2.amazonaws.com/satellytes-website/backend:1cfb651f73fcd20895fc44c06f7bb180ca0e8322"
  container_port               = var.app_port
  container_cpu                = "256"
  container_memory             = "512"
  container_memory_reservation = "300"
}

resource "aws_ecs_service" "satellytes-service" {
  name            = "cb-service"
  cluster         = aws_ecs_cluster.satellytes-cluster.id
  task_definition = module.td.aws_ecs_task_definition_td_arn
  desired_count   = 1
  launch_type     = "FARGATE"

  network_configuration {
    security_groups  = [aws_security_group.security-group-main.id]
    subnets          = module.vpc.public_subnets
    assign_public_ip = true
  }
}

