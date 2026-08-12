# Vcenter.ViJson.OpenApi.Model.VirtualMachineDiskDeviceInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identification of the endpoint on the host.  The format of this depends on the kind of virtual device this endpoints is used for. For example, for a VirtualEthernetCard this would be a networkname, and for a VirtualCDROM it would be a device name.  | 
**ConfigurationTag** | **List&lt;string&gt;** | List of configurations that this device is available for.  This is only filled out if more than one configuration is requested.  | [optional] 
**Capacity** | **long** | Size of disk  | [optional] 
**Vm** | [**List&lt;ManagedObjectReference&gt;**](ManagedObjectReference.md) | List of known virtual machines using this physical disk as a backing  Refers instances of *VirtualMachine*.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

