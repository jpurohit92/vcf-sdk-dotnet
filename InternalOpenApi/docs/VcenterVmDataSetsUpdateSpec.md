# Vcenter.Automation.OpenApi.Model.VcenterVmDataSetsUpdateSpec
The Vcenter.Vm.DataSets.UpdateSpec schema describes attributes of a data set that can be modified.  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of how the data set is used by its creator. This field can contain up to 1024 bytes.  This property was added in __vSphere API 8.0.0.0__.  If set, the value is changed. | [optional] 
**Host** | **string** | The access control from the host.  Possible values:   - &#x60;NONE&#x60;: No access is allowed for data set Entries.   - &#x60;READ_ONLY&#x60;: Only read access is allowed for data set Entries.   - &#x60;READ_WRITE&#x60;: Full read, write and delete access is allowed on data set Entries.   For more information see: *Vcenter.Vm.DataSets.Access*.  This property was added in __vSphere API 8.0.0.0__.  If set, the value is changed. | [optional] 
**Guest** | **string** | The access control from the guest.  Possible values:   - &#x60;NONE&#x60;: No access is allowed for data set Entries.   - &#x60;READ_ONLY&#x60;: Only read access is allowed for data set Entries.   - &#x60;READ_WRITE&#x60;: Full read, write and delete access is allowed on data set Entries.   For more information see: *Vcenter.Vm.DataSets.Access*.  This property was added in __vSphere API 8.0.0.0__.  If set, the value is changed. | [optional] 
**OmitFromSnapshotAndClone** | **bool** | If set, the data set is considered a property of the virtual machine, and is not included in a snapshot operation or when the virtual machine is cloned. When a virtual machine is reverted to a snapshot, any data set with {@link #omitFromSnapshotAndClone) {@term set} will be destroyed. Any data set with {@link #omitFromSnapshotAndClone} {@term unset} will be restored to the state when the snapshot was created.  This property was added in __vSphere API 8.0.0.0__.  If set, the value is changed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

