provider "aws" {
  region                  = "us-east-2"
  shared_credentials_file = "$HOME/.aws/credentials"
  profile                 = "satellytes"
}



data "aws_region" "current" {

}

data "aws_availability_zones" "available" {}
