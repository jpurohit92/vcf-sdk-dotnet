# Vcenter.ViJson.OpenApi.Model.HostActiveDirectoryInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JoinedDomain** | **string** | The domain that this host joined.  | [optional] 
**TrustedDomain** | **List&lt;string&gt;** | List of domains with which the &lt;code&gt;joinedDomain&lt;/code&gt; has a trust.  The &lt;code&gt;joinedDomain&lt;/code&gt; is not included in the &lt;code&gt;trustedDomain&lt;/code&gt; list.  | [optional] 
**DomainMembershipStatus** | **string** | Health information about the domain membership.  See *HostActiveDirectoryInfoDomainMembershipStatus_enum*.  | [optional] 
**SmartCardAuthenticationEnabled** | **bool** | Deprecated as of vSphere API 8.0U3, and there is no replacement for it.  Whether local smart card authentication is enabled.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

