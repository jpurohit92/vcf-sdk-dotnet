# Vcenter.ViJson.OpenApi.Model.HostFirewallRuleset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | Brief identifier for the ruleset.  | 
**Label** | **string** | Display label for the ruleset.  | 
**Required** | **bool** | Flag indicating whether the ruleset is required and cannot be disabled.  | 
**Rule** | [**List&lt;HostFirewallRule&gt;**](HostFirewallRule.md) | List of rules within the ruleset.  | 
**Service** | **string** | Managed service (if any) that uses this ruleset.  Must be one of the services listed in *HostServiceInfo.service*.  | [optional] 
**Enabled** | **bool** | Flag indicating whether the ruleset is enabled.  If the ruleset is enabled, all ports specified in the ruleset are opened by the firewall.  | 
**AllowedHosts** | [**HostFirewallRulesetIpList**](HostFirewallRulesetIpList.md) | List of ipaddress to allow access to the service  | [optional] 
**UserControllable** | **bool** | Flag indicating whether user can enable/disable the firewall ruleset.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 
**IpListUserConfigurable** | **bool** | Flag indicating whether user can modify the allowed IP list of the firewall ruleset.  ***Since:*** vSphere API Release 8.0.2.0  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

