# Vcenter.ViJson.OpenApi.Model.VsanVibScanRequestType
The parameters of *VsanUpdateManager.VsanVibScan*.  This structure may be used only with operations rendered under `/vsan`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | [**ManagedObjectReference**](ManagedObjectReference.md) | Optional cluster this scan is happening in reference to.  ***Required privileges:*** System.Read  Refers instance of *ComputeResource*.  | [optional] 
**VibSpecs** | [**List&lt;VsanVibSpec&gt;**](VsanVibSpec.md) | List of VIB specs to check (one entry per host)  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

