# Vcenter.ViJson.OpenApi.Model.HostTpmOptionEventDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataHash** | **List&lt;int&gt;** | Value of the Platform Configuration Register (PCR) for this event.  | 
**DataHashMethod** | **string** | Method in which the digest hash is calculated.  The set of possible values is described in *HostDigestInfoDigestMethodType_enum*.  | [optional] 
**OptionsFileName** | **string** | Name of the file containing the boot options.  | 
**BootOptions** | **List&lt;int&gt;** | Options set by the boot option package.  This array exposes the raw contents of the settings file (or files) that were passed to kernel during the boot up process, and, therefore, should be treated accordingly.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

