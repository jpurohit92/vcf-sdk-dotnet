# Vcenter.ViJson.OpenApi.Model.VmProtected
An agent virtual machine is protected from modifications (example: HA recovery).  This is an active remediable issue. To remediate, vSphere ESX Agent Manager modifies the virtual machine.  This structure may be used only with operations rendered under `/eam`.  ***Since:*** vEAM API 9.0 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Vm** | [**ManagedObjectReference**](ManagedObjectReference.md) | The virtual machine to which this issue is related.  Refers instance of *VirtualMachine*.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

