# :cloud: AZ-204 Certification Exam :cloud:

This is my study guide :pencil: for **AZ-204 Certification Exam**.

- [:cloud: AZ-204 Certification Exam :cloud:](#️-az-204-certification-exam-️)
  - [Content](#content)
    - [Develop Azure compute solutions (25-30%)](#develop-azure-compute-solutions-25-30)
      - [Implement IaaS solutions](#implement-iaas-solutions)
      - [Create Azure App Service Web Apps](#create-azure-app-service-web-apps)
      - [Implement Azure functions](#implement-azure-functions)
    - [Develop for Azure storage (10-15%)](#develop-for-azure-storage-10-15)
      - [Develop solutions that use Cosmos DB storage](#develop-solutions-that-use-cosmos-db-storage)
      - [Develop solutions that use blob storage](#develop-solutions-that-use-blob-storage)
    - [Implement Azure security (15-20%)](#implement-azure-security-15-20)
      - [Implement user authentication and authorization](#implement-user-authentication-and-authorization)
      - [Implement secure cloud solutions](#implement-secure-cloud-solutions)
    - [Monitor, troubleshoot, and optimize Azure solutions (10-15%)](#monitor-troubleshoot-and-optimize-azure-solutions-10-15)
      - [Integrate caching and content delivery within solutions](#integrate-caching-and-content-delivery-within-solutions)
      - [Instrument solutions to support monitoring and logging](#instrument-solutions-to-support-monitoring-and-logging)
    - [Connect to and consume Azure services and third-party services (25-30%)](#connect-to-and-consume-azure-services-and-third-party-services-25-30)
      - [Develop an App Service Logic App](#develop-an-app-service-logic-app)
      - [Implement API Management](#implement-api-management)
      - [Develop event-based solutions](#develop-event-based-solutions)
      - [Develop message-based solutions](#develop-message-based-solutions)
  - [Resources](#resources)

## Content

### Develop Azure compute solutions (25-30%)

#### Implement IaaS solutions

- Provision VMs
  - [Intro to VM](https://docs.microsoft.com/en-us/learn/modules/intro-to-azure-virtual-machines/)
  - [Create Windows VM](https://docs.microsoft.com/en-us/learn/modules/create-windows-virtual-machine-in-azure/)
  - [Create Linux VM](https://docs.microsoft.com/en-us/learn/modules/create-linux-virtual-machine-in-azure/)
  - [VM with Azure CLI](https://docs.microsoft.com/en-us/learn/modules/manage-virtual-machines-with-azure-cli/)
  - [VM with Azure PowerShell](https://docs.microsoft.com/en-us/azure/virtual-machines/windows/tutorial-manage-vm)

- Configure VMs for remote access
  - [Create Azure VM technical asset](https://docs.microsoft.com/en-us/azure/marketplace/partner-center-portal/create-azure-vm-technical-asset)
  - [Secure your management ports with just-in-time access](https://docs.microsoft.com/en-us/azure/security-center/security-center-just-in-time)
- Create ARM templates
  - [ARM functionality](https://docs.microsoft.com/en-us/azure/architecture/building-blocks/extending-templates/)
  - [ARM overview](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/overview)
  - [Create and deploy ARM template](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/template-tutorial-create-first-template?tabs=azure-powershell)

- Create container images for solutions by using Docker
  - [Build and deploy container images with ACR Tasks](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-tutorial-quick-task)
  - [Create container images on a Linux Service Fabric cluster](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-create-container-images)
  - [Create a container image for deployment to Azure Container Instances](https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-tutorial-create-container-images)
  - [Build and store container images with ACR (Learn Module)](https://docs.microsoft.com/en-us/learn/modules/build-and-store-container-images/)

- Publish an image to the Azure Container Registry
  - [Push container to ACR using Docker CLI](https://docs.microsoft.com/en-us/azure/container-registry/container-registry-get-started-docker-cli)

- Run containers by using Azure Container Instance
  - [Run docker with ACI (Learn Module)](https://docs.microsoft.com/en-us/learn/modules/run-docker-with-azure-container-instances/)
  - [What is Azure Container Instances?](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-overview)
  - [Quickstart: Deploy a container instance in Azure using the Azure CLI](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-quickstart)
  - [Quickstart: Deploy a container instance in Azure using the Azure portal](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-quickstart-portal)
  - [Quickstart: Deploy a container instance in Azure using Azure PowerShell](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-quickstart-powershell)
  - [Tutorial: Deploy a container application to Azure Container Instances](https://docs.microsoft.com/en-us/azure/container-instances/container-instances-tutorial-deploy-app)

#### Create Azure App Service Web Apps

- Create an Azure App Service Web App
- Enable diagnostics logging
- Deploy code to a web app
- Configure web app settings including SSL, API, and connection strings
- Implement autoscaling rules, including scheduled autoscaling, and scaling by operational or system metrics

#### Implement Azure functions

- Implement input and output bindings for a function
- Implement function triggers by using data operations, timers, and webhooks
- Implement Azure Durable Functions

### Develop for Azure storage (10-15%)

#### Develop solutions that use Cosmos DB storage

- Select the appropriate API for your solution
    - [Choose api for Cosmos Db (Learn Module)](https://docs.microsoft.com/en-us/learn/modules/choose-api-for-cosmos-db/)
    - [Introduction to Cosmos Db](https://docs.microsoft.com/en-us/azure/cosmos-db/introduction)
- Implement partitioning schemes
- Interact with data using the appropriate SDK
- Set the appropriate consistency level for operations
- Create Cosmos DB containers 
- Implement scaling (partitions, containers)
- Implement server-side programming including stored procedures, triggers, and change feed notifications

#### Develop solutions that use blob storage

- Move items in Blob storage between storage accounts or containers
- Set and retrieve properties and metadata
- Interact with data using the appropriate SDK
- Implement data archiving and retention
- Implement hot, cool, and archive storage

### Implement Azure security (15-20%)

#### Implement user authentication and authorization

- Implement OAuth2 authentication
- Create and implement shared access signatures
- Register apps and use Azure Active Directory to authenticate users
- Control access to resources by using role-based access controls (RBAC)

#### Implement secure cloud solutions

- Secure app configuration data by using the App Configuration and KeyVault API
- Manage keys, secrets, and certificates by using the KeyVault API
    - [About keys, secrets, and certificates](https://docs.microsoft.com/en-us/azure/key-vault/general/about-keys-secrets-certificates)
    - [Manage secrets with Azure Key Vault](https://docs.microsoft.com/en-us/learn/modules/manage-secrets-with-azure-key-vault/)
- Implement Managed Identities for Azure resources

### Monitor, troubleshoot, and optimize Azure solutions (10-15%)

#### Integrate caching and content delivery within solutions

- Develop code to implement CDNs in solutions
- Configure cache and expiration policies for FrontDoor, CDNs, or Redis caches Store and retrieve data in Azure Redis cache

#### Instrument solutions to support monitoring and logging

- Configure instrumentation in an app or service by using Application Insights
- Analyze log data and troubleshoot solutions by using Azure Monitor
- Implement Application Insights Web Test and Alerts
- Implement code that handles transient faults

### Connect to and consume Azure services and third-party services (25-30%)

#### Develop an App Service Logic App

- Create a Logic App
- Create a custom connector for Logic Apps
- Create a custom template for Logic Apps

#### Implement API Management

- Create an APIM instance
    - [Create a new Azure API Management service instance](https://docs.microsoft.com/en-us/azure/api-management/get-started-create-service-instance)
- Configure authentication for APIs
    - [Control authentication for your APIs with Azure API Management](https://docs.microsoft.com/en-us/learn/modules/control-authentication-with-apim/)
- Define policies for APIs
    - [Protect your APIs on Azure API Management](https://docs.microsoft.com/en-us/learn/modules/protect-apis-on-api-management/)

#### Develop event-based solutions

- Implement solutions that use Azure Event Grid
- Implement solutions that use Azure Notification Hubs
- Implement solutions that use Azure Event Hub

#### Develop message-based solutions

- Implement solutions that use Azure Service Bus
- Implement solutions that use Azure Queue Storage queues

## Learning path Microsoft

- [Create serverless applications](https://docs.microsoft.com/en-us/learn/paths/create-serverless-applications/)
- [Work with NoSQL data in Azure Cosmos DB](https://docs.microsoft.com/en-us/learn/paths/work-with-nosql-data-in-azure-cosmos-db/)
- [Administer containers in Azure](https://docs.microsoft.com/en-us/learn/paths/administer-containers-in-azure/)
- [Architect API integration in Azure](https://docs.microsoft.com/en-us/learn/paths/architect-api-integration/)
- [Architect message brokering and serverless applications in Azure](https://docs.microsoft.com/en-us/learn/paths/architect-messaging-serverless/)

## Courses
- [AZ-203 / AZ-204 Developing for Microsoft Azure Exam Prep  (Scott Duffy - Udemy)](https://www.udemy.com/course/70532-azure/)
- [AZ-203 Developing Solutions for Microsoft Azure (Whizlabs)](https://www.whizlabs.com/learn/course/microsoft-azure-az-203/)
- [AZ-203 Developing Solutions for Microsoft Azure (Pluralsight)](https://app.pluralsight.com/paths/certificate/developing-solutions-for-microsoft-azure-az-203)

## Links

- [Official site AZ-204 Certification Exam](https://docs.microsoft.com/en-us/learn/certifications/exams/az-204)
- [Thomas Maurer study guide](https://www.thomasmaurer.ch/2020/03/az-204-study-guide-developing-solutions-for-microsoft-azure/)
