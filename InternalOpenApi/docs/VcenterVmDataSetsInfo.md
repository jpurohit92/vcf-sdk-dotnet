# Vcenter.Automation.OpenApi.Model.VcenterVmDataSetsInfo
The Vcenter.Vm.DataSets.Info schema describes a data set.  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the data set.  This property was added in __vSphere API 8.0.0.0__. | 
**Description** | **string** | A description of how the data set is used by its creator.  This property was added in __vSphere API 8.0.0.0__. | 
**Host** | **string** | Host access control.    Controls access to the data set by the *Vcenter.Vm.DataSets.Entries* operations.  Possible values:   - &#x60;NONE&#x60;: No access is allowed for data set Entries.   - &#x60;READ_ONLY&#x60;: Only read access is allowed for data set Entries.   - &#x60;READ_WRITE&#x60;: Full read, write and delete access is allowed on data set Entries.   For more information see: *Vcenter.Vm.DataSets.Access*.  This property was added in __vSphere API 8.0.0.0__. | 
**Guest** | **string** | Guest access control.    Controls access to the data set from in-guest APIs.  Possible values:   - &#x60;NONE&#x60;: No access is allowed for data set Entries.   - &#x60;READ_ONLY&#x60;: Only read access is allowed for data set Entries.   - &#x60;READ_WRITE&#x60;: Full read, write and delete access is allowed on data set Entries.   For more information see: *Vcenter.Vm.DataSets.Access*.  This property was added in __vSphere API 8.0.0.0__. | 
**Used** | **long** | The total size in bytes of the Entry data in use by this data set.  This property was added in __vSphere API 8.0.0.0__. | 
**OmitFromSnapshotAndClone** | **bool** | If set, the data set is considered a property of the virtual machine, and is not included in a snapshot operation or when the virtual machine is cloned. When a virtual machine is reverted to a snapshot, any data set with {@link #omitFromSnapshotAndClone) {@term set} will be destroyed. Any data set with {@link #omitFromSnapshotAndClone} {@term unset} will be restored to the state when the snapshot was created.  This property was added in __vSphere API 8.0.0.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

