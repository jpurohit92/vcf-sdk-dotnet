# Vcenter.ViJson.OpenApi.Model.SSDEnduranceThresholdSpec

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clustername** | **string** | The vSAN cluster name which is set for per cluster ssd endurance spec.  | 
**Clusternameop** | **string** | The operator name which is set for cluster name comparison.  Support below enum values. \\- equals \\- notEqualTo \\- startsWith \\- doesNotStartWith \\- endsWith \\- doesNotEndWith  | [optional] 
**Hostname** | **string** | The host name in vSAN cluster which is set for per host ssd endurance spec.  | [optional] 
**Hostnameop** | **string** | The operator name which is set for host name comparison.  Support below enum values. \\- equals \\- notEqualTo \\- startsWith \\- doesNotStartWith \\- endsWith \\- doesNotEndWith  | [optional] 
**Diskname** | **string** | The disk name(e.g.  t10.NVMe\\_\\_\\_\\_Dell\\_Express\\_Flash\\_NVMe\\_P4510\\_1TB\\_SFF) in vSAN cluster which is set for per disk ssd endurance spec. The disk name can be queried through command &#39;vdq -i&#39; on ESXi  | [optional] 
**Disknameop** | **string** | The operator name which is set for disk name comparison.  Support below enum values. \\- equals \\- notEqualTo \\- startsWith \\- doesNotStartWith \\- endsWith \\- doesNotEndWith  | [optional] 
**Diskvendorname** | **string** | The name of disk vendor in vSAN cluster which is set for per disk ssd endurance spec.  The vendor name of disk can be queried through command &#39;vsish -e get /storage/scsifw/devices/&amp;lt;diskName&amp;gt;/info | grep \&quot;vendor :\&quot;&#39;  | [optional] 
**Diskvendorop** | **string** | The operator name which is set for disk vendor comparison.  Support below enum values. \\- equals \\- notEqualTo \\- startsWith \\- doesNotStartWith \\- endsWith \\- doesNotEndWith  | [optional] 
**SsdEndurancePtg** | **float** | The warning disk endurance alarm will be triggered when the percentage is reached.  | 
**Severity** | **string** | The severity of alarm rule.  Support below enum values \\- red \\- yellow  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

