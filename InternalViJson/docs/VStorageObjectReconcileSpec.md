# Vcenter.ViJson.OpenApi.Model.VStorageObjectReconcileSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastore** | [**ManagedObjectReference**](ManagedObjectReference.md) | The datastore managed object that is to be reconciled/scanned.  Refers instance of *Datastore*.  | 
**IncludeDiskPaths** | **List&lt;string&gt;** | List of paths of the disk descriptor files which are to be reconciled or scanned.  This is an optional parameter and if specified, the reconciliation will scan only these disk paths and reconcile the catalog. This will save time and avoid scanning all the vmdk files. The disk paths should belong to the same datastore. The field should adhere to the following format: /vmfs/volume/&amp;lt;datastore-uuid&amp;gt;/.../&amp;lt;disk-name&amp;gt;.vmdk . Please note, either this field or *VStorageObjectReconcileSpec.excludeDiskPaths* should be specified in *VStorageObjectReconcileSpec* and not both.  | [optional] 
**ExcludeDiskPaths** | **List&lt;string&gt;** | List of paths of the disk descriptor files which are excluded for reconcile or scan operation.  This is an optional parameter and if specified, the reconciliation will skip these disk paths. This will be useful in a case when user wants to reconcile complete datastore and skip few set of the FCD&#39;s which are present in same datastore. The disk paths should belong to the same datastore. The field should adhere to the following format: /vmfs/volume/&amp;lt;datastore-uuid&amp;gt;/.../&amp;lt;disk-name&amp;gt;.vmdk Please note, either *VStorageObjectReconcileSpec.includeDiskPaths* or this field should be specified in *VStorageObjectReconcileSpec* and not both.  | [optional] 
**DeepScan** | **bool** | If true - Checks extent files and disk descriptor file contents Also evaluates and corrects the &#x60;ddb.fcd.useCount&#x60; values on relevant VMDKs, if it is incorrectly set.  &#x60;ddb.fcd.useCount&#x60; correction only happens when reconciling the entire datastore with *VStorageObjectReconcileSpec.deepScan* set to true. If either *VStorageObjectReconcileSpec.includeDiskPaths* or *VStorageObjectReconcileSpec.excludeDiskPaths* are specified, &#x60;ddb.fcd.useCount&#x60; evaluation will not be performed. Note that this is a time consuming process.  | [optional] 
**DryRun** | **bool** | If true - Does not reconcile but only scans the datastore.  | [optional] 
**GenerateReport** | **int** | If set to 1, generate report for *HostVStorageObjectManager.HostReconcileDatastoreInventoryEx_Task* task.  If set to 0 or unset, do not generate report Partner apps can use 0 and 1 as values. Other values are reserved for future and internal use.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

