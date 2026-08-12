# Vcenter.ViJson.OpenApi.Model.VsanFileServiceConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Indicates whether file service is enabled in the vSAN cluster.  | 
**FileServerMemoryMB** | **long** | The reserved memory used by VDFS backend services, like server, proxy and sockrelay.  The unit is MB. The default and minimum value is 960. This reconfiguration takes effect during enabling file service. That means, file service should be disabled firstly if it is running.  | [optional] 
**FileServerCPUMhz** | **long** | The reserved CPU used by VDFS backend services, like server, proxy and sockrelay.  The units is MHZ. The default value is 0, which means no dedicated CPU resources is bound. This reconfiguration takes effect during enabling file service. That means, file service should be disabled first if it is running.  | [optional] 
**FsvmMemoryMB** | **long** | The reserved memory used by vSAN file service virtual machines.  The unit is MB. The default and minimum values is 2048. This reconfiguration takes effect during enabling file service. That means, file service should be disabled first if it is running.  | [optional] 
**FsvmCPU** | **long** | CPU cores configured for vSAN File Service Virtual Machine(by default is 2).  This reconfiguration takes effect during enabling file service. That means, file service should be disabled first if it is running.  | [optional] 
**Network** | [**ManagedObjectReference**](ManagedObjectReference.md) | The network that the file service will be deployed on to provide file access.  Please note the security setting of this network will be updated with forged transmit and promiscuous mode enabled.  Refers instance of *Network*.  | [optional] 
**Domains** | [**List&lt;VsanFileServiceDomainConfig&gt;**](VsanFileServiceDomainConfig.md) | The list of domains created.  The first element of this list is the default domain. Leave this field empty when there is no domain to be configured with the file service enable process.  | [optional] 
**FileAnalyticsEnabled** | **bool** | Indicates whether file analytics is enabled in the vSAN cluster.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

