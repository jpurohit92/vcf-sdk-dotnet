# Vcenter.ViJson.OpenApi.Model.VirtualMachineConfigOptionDescriptor

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A unique key used to identify a configOption object in this *EnvironmentBrowser*.  | 
**Description** | **string** | A description of the configOption object.  | [optional] 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of hosts to which this descriptor applies.  List of hosts is not set when descriptor is returned from *Datacenter.queryDatacenterConfigOptionDescriptor*.  Refers instances of *HostSystem*.  | [optional] 
**CreateSupported** | **bool** | Indicates whether the associated set of configuration options can be used for virtual machine creation on a given host or cluster.  | 
**DefaultConfigOption** | **bool** | Indicates whether the associated set of virtual machine configuration options is the default one for a given host or cluster.  Latest version is marked as default unless other version is specified via *ComputeResourceConfigInfo.defaultHardwareVersionKey* or *DatacenterConfigInfo.defaultHardwareVersionKey*. If this setting is TRUE, virtual machine creates will use the associated set of configuration options, unless a config version is explicitly specified in the *ConfigSpec*.  | 
**RunSupported** | **bool** | Indicates whether the associated set of configuration options can be used to power on a virtual machine on a given host or cluster.  | 
**UpgradeSupported** | **bool** | Indicates whether the associated set of configuration options can be used as a virtual hardware upgrade target.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

