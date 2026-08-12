# Vcenter.ViJson.OpenApi.Model.ClusterNetworkConfigSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkPortGroup** | [**ManagedObjectReference**](ManagedObjectReference.md) | The portgroup that is associated with the VCHA Cluster IP address for VCHA cluster traffic for the second adapter to be added to the Active vCenter.  Refers instance of *Network*.  | 
**IpSettings** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | VCHA Cluster network configuration of the node.  All cluster communication (state replication, heartbeat, cluster messages) happens over this network. Only a single Gateway IPv4 Address is supported. IPAddress and NetMask must be specified or an InvalidArgument exception will be reported.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

