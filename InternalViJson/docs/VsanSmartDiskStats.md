# Vcenter.ViJson.OpenApi.Model.VsanSmartDiskStats

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Disk** | **string** | The physical disk name with the format like \&quot;mpx.vmhba1:C0:T2:L0\&quot;.  | 
**Stats** | [**List&lt;VsanSmartParameter&gt;**](VsanSmartParameter.md) | A list of S.M.A.R.T.  stats for the disk.  | [optional] 
**Error** | [**MethodFault**](MethodFault.md) | If error is set, it fails to get S.M.A.R.T.  stats for the disk with issues like \&quot;CANNOT open device\&quot;, or \&quot;GET SMART parameters error\&quot;.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

