# Vcenter.ViJson.OpenApi.Model.HostActiveDirectorySpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DomainName** | **string** | Domain name.  | [optional] 
**UserName** | **string** | Name of an Active Directory account with the authority to add a host to the domain.  | [optional] 
**Password** | **string** | Password for the Active Directory account.  | [optional] 
**CamServer** | **string** | If set, the CAM server will be used to join the domain and the &lt;code&gt;userName&lt;/code&gt; and &lt;code&gt;password&lt;/code&gt; fields will be ignored.  | [optional] 
**Thumbprint** | **string** | Thumbprint for the SSL certificate of CAM server  | [optional] 
**Certificate** | **string** | PEM-encoded certificate of the CAM server This field replaces *HostActiveDirectorySpec.thumbprint*.  If both *HostActiveDirectorySpec.thumbprint* and *HostActiveDirectorySpec.certificate* fields are set, the *HostActiveDirectorySpec.thumbprint* should match the *HostActiveDirectorySpec.certificate*.  ***Since:*** vSphere API Release 8.0.3.0  | [optional] 
**SmartCardAuthenticationEnabled** | **bool** | Deprecated as of vSphere API 8.0U3, and there is no replacement for it.  Support smart card authentication of local users.  | [optional] 
**SmartCardTrustAnchors** | **List&lt;string&gt;** | Deprecated as of vSphere API 8.0U3, and there is no replacement for it.  Trusted root certificates for smart cards.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

