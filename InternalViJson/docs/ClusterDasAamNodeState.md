# Vcenter.ViJson.OpenApi.Model.ClusterDasAamNodeState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | [**ManagedObjectReference**](ManagedObjectReference.md) | Reference to the host.  Refers instance of *HostSystem*.  | 
**Name** | **string** | Name of the host (*HostSystem*.*ManagedEntity.name*).  | 
**ConfigState** | **string** | Configuration state of the HA agent on the host.  The property can be one of the following values:  configuring   error   unconfiguring   running    &lt;code&gt;configState&lt;/code&gt; represents setting or resetting the HA configuration on the host. If the configuration operation is successful, the value of &lt;code&gt;configState&lt;/code&gt; changes to &lt;code&gt;running&lt;/code&gt;. See *ClusterDasAamNodeStateDasState_enum*.  | 
**RuntimeState** | **string** | The runtime state of the HA agent on the node.  The property can be one of the following values:  uninitialized   initialized   running   error   agentShutdown   nodeFailed  See *ClusterDasAamNodeStateDasState_enum*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

