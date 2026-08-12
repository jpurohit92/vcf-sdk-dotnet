# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsSolutionsHostSolutionInfo
The Esx.Settings.Clusters.Vms.Solutions.HostSolutionInfo schema contains properties that describe solution configuration only applicable for solutions with deployment type *Esx.Settings.Clusters.Vms.DeploymentType.EVERY_HOST_PINNED*  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PreferHostConfiguration** | **bool** | Describes whether the VM datastore and network configured through vim.host.EsxAgentHostManager take precedence over the networks and datastores specified by the vmNetworks and vmDatastores properties when configuring the VMs.    NOTE: This option is reserved only for NSX and future plans are to be deprecated.  This property was added in __vSphere API 9.0.0.0__. | 
**VmNetworks** | **List&lt;string&gt;** | Networks to be configured on the VMs. The first available network on the host is used.    If the prefer_host_configuration is set to &#x60;true&#x60;, the default network configured through vim.host.EsxAgentHostManager will take precedence over the specified by the vm_networks.   This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Network&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Network&#x60;. | 
**VmDatastores** | **List&lt;string&gt;** | Datastores to be configured as a storage of the VMs. The first available datastore on the host is used.    If the prefer_host_configuration is set to &#x60;true&#x60;, the default datastore configured through vim.host.EsxAgentHostManager will take precedence over the specified by vm_datastores.   This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;Datastore&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;Datastore&#x60;. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

