# Terraform installation

Terraform is an open-source infrastructure as code software tool created by HashiCorp. It enables users to define and provision a datacenter infrastructure using a high-level configuration language known as Hashicorp Configuration Language (HCL), or optionally JSON. Terraform supports a number of cloud infrastructure providers such as Amazon Web Services

## Prerequisites
Download Terraform CLI and unzip it into the local folder or a $PATH folder\
e.g. https://techcommunity.microsoft.com/t5/azure-developer-community-blog/configuring-terraform-on-windows-10-linux-sub-system/ba-p/393845

Test with `terraform -v` if terraform CLI will be found

Create your credentials file for accessing aws (here linux) in `$HOME/.aws/credentials`
If you changed the path to the credentials file you have to change the path in the file provider.tf -> shared_credentials_file as well.

```
[profile satellytes]
aws_access_key_id=<AWS_ACCESS_KEY>
aws_secret_access_key=<AWS_SECRET_KEY>
region=us-east-2
```

## Deployment
- Start a cmd / shell in the local directory
- type `terraform init` to download all necessary modules
- type `terraform deploy` to create the necessary resources
- to destroy the resource afterwards type `terraform destroy`
