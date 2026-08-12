# Vcenter.Automation.OpenApi.Model.ApplianceTlsManualParametersGlobalSetSpec
The Appliance.Tls.ManualParameters.Global.SetSpec schema contains the information about the TLS Profile.  This schema was added in __vSphere API 8.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProtocolVersions** | [**List&lt;ApplianceTlsManualParametersGlobalProtocolVersionInfo&gt;**](ApplianceTlsManualParametersGlobalProtocolVersionInfo.md) | Defines the list of TLS protocol version and their ciphers  This property was added in __vSphere API 8.0.3.0__. | 
**Curves** | **List&lt;string&gt;** | Defines the TLS Profile curves in IANA form.  This property was added in __vSphere API 8.0.3.0__. | 
**FipsEnforced** | **bool** | This property is deprecated as of __vSphere API 9.0.0.0__. in 9.0.0.0 and above all profiles are FIPS compliant, always @term true.  Indicates if FIPS 140-3 compliance is enforced for the TLS Profile.  This property was added in __vSphere API 8.0.3.0__. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

