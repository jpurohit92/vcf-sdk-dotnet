# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementNetworksEdgesFoundationSyslog
A Vcenter.NamespaceManagement.Networks.Edges.Foundation.Syslog configuration defines how logs are exported using the syslog protocol.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Endpoint** | **string** | FQDN or IP address of the remote syslog server taking the form &#x60;&#x60;&#x60;protocol://hostname|ipv4|ipv6[:port]&#x60;&#x60;&#x60;. The syslog protocol defaults to tcp.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; logs will be persisted locally. | [optional] 
**CertificateAuthorityPem** | **string** | The Certificate Authority certificate can be provided in PEM format to validate the *Vcenter.NamespaceManagement.Networks.Edges.Foundation.Syslog.endpoint* when using a TLS protocol.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60; no validation will be performed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

