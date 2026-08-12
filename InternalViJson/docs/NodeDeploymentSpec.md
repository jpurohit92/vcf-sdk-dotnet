# Vcenter.ViJson.OpenApi.Model.NodeDeploymentSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EsxHost** | [**ManagedObjectReference**](ManagedObjectReference.md) | ESX host on which the VM is to be deployed.  For behavior when an esxHost is not specified,  See also *VirtualMachineRelocateSpec.host*.  Refers instance of *HostSystem*.  | [optional] 
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | Datastore used for deploying the VM.  For behavior when a datastore is not specified,  See also *VirtualMachineRelocateSpec.datastore*.  Refers instance of *Datastore*.  | [optional] 
**PublicNetworkPortGroup** | [**ManagedObjectReference**](ManagedObjectReference.md) | Name of the portgroup that is associated with the public IP address where clients connect to vCenter Server.  If a portgroup is not specified same portgroup present on source is used to deploy the VM with an assumption that portgroup is present on destination.  Refers instance of *Network*.  | [optional] 
**ClusterNetworkPortGroup** | [**ManagedObjectReference**](ManagedObjectReference.md) | Name of the portgroup that is associated with the VCHA Cluster IP address where clients connect to vCenter Server.  If a portgroup is not specified same portgroup present on source is used to deploy the VM with an assumption that portgroup is present on destination.  Refers instance of *Network*.  | [optional] 
**Folder** | [**ManagedObjectReference**](ManagedObjectReference.md) | Folder in which the VM is to be created.  Refers instance of *Folder*.  | 
**ResourcePool** | [**ManagedObjectReference**](ManagedObjectReference.md) | ResourcePool that will be used to deploy this node.  If the ResourcePool is not specified, the root resource pool for the host will be used.  Refers instance of *ResourcePool*.  | [optional] 
**ManagementVc** | [**ServiceLocator**](ServiceLocator.md) | Management vCenter Server managing this VM.  If the managementVc is not specified, managementVc specified as part of SourceNodeSpec is used.  | [optional] 
**NodeName** | **string** | nodeName here refers to a name that will be assigned to the VM to which this node will be deployed to.  | 
**IpSettings** | [**CustomizationIPSettings**](CustomizationIPSettings.md) | VCHA Cluster network configuration of the node.  All cluster communication (state replication, heartbeat, cluster messages) happens over this network.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

