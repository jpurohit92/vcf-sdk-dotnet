# Vcenter.ViJson.OpenApi.Model.HostInternetScsiHbaAuthenticationCapabilities

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChapAuthSettable** | **bool** | True if this host bus adapter supports changing the configuration state of CHAP authentication.  CHAP is mandatory, however some adapter may not allow disabling this authentication method.  | 
**Krb5AuthSettable** | **bool** | Always false in this version of the API.  | 
**SrpAuthSettable** | **bool** | Always false in this version of the API.  | 
**SpkmAuthSettable** | **bool** | Always false in this version of the API.  | 
**MutualChapSettable** | **bool** | When chapAuthSettable is TRUE, this describes if Mutual CHAP configuration is allowed as well.  | [optional] 
**TargetChapSettable** | **bool** | When targetChapSettable is TRUE, this describes if CHAP configuration is allowed on targets associated with the adapter.  | [optional] 
**TargetMutualChapSettable** | **bool** | When targetMutualChapSettable is TRUE, this describes if Mutual CHAP configuration is allowed on targets associated with the adapter.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

