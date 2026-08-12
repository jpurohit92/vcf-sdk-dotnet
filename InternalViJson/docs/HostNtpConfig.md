# Vcenter.ViJson.OpenApi.Model.HostNtpConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Server** | **List&lt;string&gt;** | List of time servers, specified as either IP addresses or fully qualified domain names (FQDNs).  Each entry may optionally specify one or more space separated &#39;server&#39; ntp.conf command options. Any comments appended to an entry after a &#39;#&#39; will not be retained. To reset any previously configured servers, submit an NtpConfig without the server or configFile property set to method *HostDateTimeSystem.UpdateDateTimeConfig*  | [optional] 
**ConfigFile** | **List&lt;string&gt;** | Content of ntp.conf host configuration file, split by lines for ntpd version 4.2.8.  Comment lines start with comment marker &#39;#&#39; as per ntp.conf are kept. When submitting a new ntp commands to this property via *HostDateTimeSystem.UpdateDateTimeConfig* method, any &#39;restrict&#39; or &#39;drift&#39; commands will be ignored as the those are set to fixed defaults.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

