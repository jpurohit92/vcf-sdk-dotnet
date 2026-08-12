# Vcenter.Automation.OpenApi.Model.VcenterEnvironmentBrowserConfigOptionDescriptorsSummary
Contains the definition of a unique key that can be used to retrieve a `ConfigOption` (`vim.vm.ConfigOption`) object.  This schema was added in __vSphere API 8.0.2.00300__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConfigOption** | **string** | A unique key used to identify a ConfigOption object.  This property was added in __vSphere API 8.0.2.00300__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.config_option&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.config_option&#x60;. | 
**Description** | [**VapiStdLocalizableMessage**](VapiStdLocalizableMessage.md) | A description of the configOption object.  This property was added in __vSphere API 8.0.2.00300__.  when missing or &#x60;null&#x60; | [optional] 
**Hosts** | **List&lt;string&gt;** | List of hosts to which this descriptor applies. List of hosts is not set when descriptor is returned for a Datacenter.  This property was added in __vSphere API 8.0.2.00300__.  when missing or &#x60;null&#x60;  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;HostSystem&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;HostSystem&#x60;. | [optional] 
**CreateSupported** | **bool** | Indicates whether the associated set of configuration options can be used for virtual machine creation on a given host or cluster.  This property was added in __vSphere API 8.0.2.00300__. | 
**DefaultConfigOption** | **bool** | Indicates whether the associated set of virtual machine configuration options is the default one for a given host or cluster. Latest version is marked as default unless other version is specified via the vim.ComputeResource.ConfigInfo or vim.Datacenter.ConfigInfo defaultHardwareVersionKey.    If this setting is TRUE, virtual machine creates will use the associated set of configuration options, unless a config version is explicitly specified in the vim.vm.ConfigSpec.   This property was added in __vSphere API 8.0.2.00300__. | 
**RunSupported** | **bool** | Indicates whether the associated set of configuration options can be used to power on a virtual machine on a given host or cluster.  This property was added in __vSphere API 8.0.2.00300__. | 
**UpgradeSupported** | **bool** | Indicates whether the associated set of configuration options can be used as a virtual hardware upgrade target.  This property was added in __vSphere API 8.0.2.00300__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

