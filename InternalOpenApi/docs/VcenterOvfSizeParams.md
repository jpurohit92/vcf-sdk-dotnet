# Vcenter.Automation.OpenApi.Model.VcenterOvfSizeParams
The Vcenter.Ovf.SizeParams schema contains estimates of the download and deployment sizes.    This information is based on the file references and the ovf:DiskSection in the OVF descriptor.    See *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=deploy* and *POST /vcenter/ovf/library-item/{ovfLibraryItemId}?action=filter*.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApproximateDownloadSize** | **long** | A best guess as to the total amount of data that must be transferred to download the OVF package.    This may be inaccurate due to disk compression etc.  This property is not used in the input parameters when deploying an OVF package. This property is optional in the result when retrieving information about an OVF package. It will be missing or &#x60;null&#x60; if there is insufficient information to provide a proper estimate. | [optional] 
**ApproximateFlatDeploymentSize** | **long** | A best guess as to the total amount of space required to deploy the OVF package if using flat disks.  This property is not used in the input parameters when deploying an OVF package. This property is optional in the result when retrieving information about an OVF package. It will be missing or &#x60;null&#x60; if there is insufficient information to provide a proper estimate. | [optional] 
**ApproximateSparseDeploymentSize** | **long** | A best guess as to the total amount of space required to deploy the OVF package using sparse disks.  This property is not used in the input parameters when deploying an OVF package. This property is optional in the result when retrieving information about an OVF package. It will be missing or &#x60;null&#x60; if there is insufficient information to provide a proper estimate. | [optional] 
**VariableDiskSize** | **bool** | Whether the OVF uses variable disk sizes.    For empty disks, rather than specifying a fixed virtual disk capacity, the capacity may be given using a reference to a ovf:Property element in a ovf:ProductSection element in OVF package.  This property is not used in the input parameters when deploying an OVF package. This property is optional in the result when retrieving information about an OVF package. If missing or &#x60;null&#x60; or false, the OVF does not use variable disk sizes. | [optional] 
**Type** | **string** | Unique identifier describing the type of the OVF parameters. The value is the name of the OVF parameters schema.  This property must be provided in the input parameters when deploying an OVF package. This property will always be present in the result when retrieving information about an OVF package. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

