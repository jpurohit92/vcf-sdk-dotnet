# Vcenter.ViJson.OpenApi.Model.HostTpmSoftwareComponentEventDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataHash** | **List&lt;int&gt;** | Value of the Platform Configuration Register (PCR) for this event.  | 
**DataHashMethod** | **string** | Method in which the digest hash is calculated.  The set of possible values is described in *HostDigestInfoDigestMethodType_enum*.  | [optional] 
**ComponentName** | **string** | Name of the software component that caused this TPM event.  | 
**VibName** | **string** | Name of the VIB containing the software component.  | 
**VibVersion** | **string** | Version of the VIB containing the software component.  | 
**VibVendor** | **string** | Vendor of the VIB containing the software component.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

