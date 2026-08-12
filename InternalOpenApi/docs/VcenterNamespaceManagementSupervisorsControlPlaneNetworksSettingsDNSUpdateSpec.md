# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsControlPlaneNetworksSettingsDNSUpdateSpec
The Vcenter.NamespaceManagement.Supervisors.ControlPlane.Networks.Settings.DNSUpdateSpec schema contains updates to DNS configuration.  This schema was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServersToAdd** | **List&lt;string&gt;** | List of DNS server IP addresses to add, specified in order of preference.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no DNS servers will be added. | [optional] 
**ServersToRemove** | **List&lt;string&gt;** | List of DNS server IP addresses to remove.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no DNS servers will be removed. | [optional] 
**SearchDomainsToAdd** | **List&lt;string&gt;** | List of DNS search domains to add, specified in order of preference.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no search domains will be added. | [optional] 
**SearchDomainsToRemove** | **List&lt;string&gt;** | List of DNS search domains to remove.  This property was added in __vSphere API 9.1.0.0__.  If missing or &#x60;null&#x60;, no search domains will be removed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

