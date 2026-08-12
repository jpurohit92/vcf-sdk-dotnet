# Vcenter.ViJson.OpenApi.Model.VslmLoginByTokenRequestType
The parameters of *VslmSessionManager.VslmLoginByToken*.  This structure may be used only with operations rendered under `/vslm`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DelegatedTokenXml** | **string** | The delegated token will be retrieved by the client and delegated to VSLM. VSLM will use this token, on user&#39;s behalf, to login to VC for authorization purposes. It is necessary to convert the token to XML because the SAML token itself is not a VMODL Data Object and cannot be used as a parameter.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

