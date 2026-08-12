# Vcenter.ViJson.OpenApi.Model.DVSSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the switch.  | 
**Uuid** | **string** | The generated UUID of the switch.  | 
**NumPorts** | **int** | Current number of ports, not including conflict ports.  | 
**ProductInfo** | [**DistributedVirtualSwitchProductSpec**](DistributedVirtualSwitchProductSpec.md) | The product information for the implementation of the switch.  | [optional] 
**HostMember** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The names of the hosts that join the switch.  Refers instances of *HostSystem*.  | [optional] 
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The Virtual Machines with Virtual NICs that connect to the switch.  In releases after vSphere API 5.0, vSphere Servers might not generate property collector update notifications for this property. To obtain the latest value of the property, you can use PropertyCollector methods RetrievePropertiesEx or WaitForUpdatesEx. If you use the PropertyCollector.WaitForUpdatesEx method, specify an empty string for the version parameter. Since this property is on a DataObject, an update returned by WaitForUpdatesEx may contain values for this property when some other property on the DataObject changes. If this update is a result of a call to WaitForUpdatesEx with a non-empty version parameter, the value for this property may not be current.  Refers instances of *VirtualMachine*.  | [optional] 
**Host** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | The hosts with Virtual NICs that connect to the switch.  Refers instances of *HostSystem*.  | [optional] 
**PortgroupName** | **List&lt;string&gt;** | The names of the portgroups that are defined on the switch.  | [optional] 
**Description** | **string** | A description string of the switch.  | [optional] 
**Contact** | [**DVSContactInfo**](DVSContactInfo.md) | The human operator contact information.  | [optional] 
**NumHosts** | **int** | The number of hosts in the switch.  The value of this property is not affected by the privileges granted to the current user.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

