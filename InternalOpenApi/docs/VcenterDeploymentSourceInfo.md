# Vcenter.Automation.OpenApi.Model.VcenterDeploymentSourceInfo
The Vcenter.Deployment.SourceInfo {schema contains information about the source vCenter Server system and the database migration options.  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hostname** | **string** | The IP address or DNS resolvable name of the source vCenter Server.  This property was added in __vSphere API 7.0.0.0__. | 
**VarVersion** | **string** | Source vCenter Server version.  This property was added in __vSphere API 7.0.0.0__. | 
**DeploymentType** | **string** | Deployment type of the source vCenter Server.  Possible values:   - &#x60;VCSA_EMBEDDED&#x60;: The vCenter Server Appliance with an embedded Platform Services Controller.   - &#x60;VCSA_EXTERNAL&#x60;: The vCenter Server Appliance with an external Platform Services Controller.   - &#x60;PSC_EXTERNAL&#x60;: An external Platform Services Controller.   For more information see: *Vcenter.Deployment.ApplianceType*.  This property was added in __vSphere API 7.0.0.0__. | 
**DeploymentSize** | **string** | Deployment size of the source vCenter Server.  Possible values:   - &#x60;TINY&#x60;: Appliance size of &#39;tiny&#39;.   - &#x60;SMALL&#x60;: Appliance size of &#39;small&#39;.   - &#x60;MEDIUM&#x60;: Appliance size of &#39;medium&#39;.   - &#x60;LARGE&#x60;: Appliance size of &#39;large&#39;.   - &#x60;XLARGE&#x60;: Appliance size of &#39;extra large&#39;.   For more information see: *Vcenter.Deployment.ApplianceSize*.  This property was added in __vSphere API 7.0.0.0__. | 
**SsoDomainName** | **string** | The SSO domain name of the source vCenter Server.  This property was added in __vSphere API 7.0.0.0__. | 
**ActiveDirectoryDomain** | **string** | The domain name of the Active Directory server to which the source vCenter Server is joined.  This property was added in __vSphere API 7.0.0.0__. | 
**DnsServers** | **List&lt;string&gt;** | IP addresses of the DNS servers of the Active Directory server.  This property was added in __vSphere API 7.0.0.0__. | 
**DataMigrationInfo** | [**VcenterDeploymentDataMigrationInfo**](VcenterDeploymentDataMigrationInfo.md) | Contains all the available migrate options, estimated export and import time and the space required to migrate the data.  This property was added in __vSphere API 7.0.0.0__.  This property will be available if estimate data is available for the appliance. | [optional] 
**DiskInfo** | [**List&lt;VcenterDeploymentDiskInfo&gt;**](VcenterDeploymentDiskInfo.md) | Contains information about the list of available disks  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; disk info was not fetched for the vCenter Server filesystem. | [optional] 
**ReplicatedPartners** | **List&lt;string&gt;** | Contains information about the list of replicated partner nodes  This property was added in __vSphere API 8.0.3.0__.  If missing or &#x60;null&#x60; replicated partners information is not available for the current vCenter Server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

