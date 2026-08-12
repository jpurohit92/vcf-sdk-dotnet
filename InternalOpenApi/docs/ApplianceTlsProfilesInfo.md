# Vcenter.Automation.OpenApi.Model.ApplianceTlsProfilesInfo
The Appliance.Tls.Profiles.Info schema contains the information about the TLS Profile.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProtocolVersions** | [**List&lt;ApplianceTlsProfilesProtocolVersionInfo&gt;**](ApplianceTlsProfilesProtocolVersionInfo.md) | Defines the list of TLS protocol version and their ciphers  This property was added in __vSphere API 8.0.3.0__. | 
**Curves** | **List&lt;string&gt;** | Defines the TLS Profile curves in IANA form.  This property was added in __vSphere API 8.0.3.0__. | 
**FipsEnforced** | **bool** | This property is deprecated as of __vSphere API 9.0.0.0__. in 9.0.0.0 and above all profiles are FIPS compliant, always @term true.  Indicates if FIPS 140-3 compliance is enforced for the TLS Profile. If FIPS is not enforced, some TLS features that have not been yet FIPS validated can be enabled by some crypto modules. If FIPS is enforced, non FIPS validated TLS features wont be in effect.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

