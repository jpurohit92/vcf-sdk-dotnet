# Vcenter.ViJson.OpenApi.Model.ClusterVmHostRuleInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **int** | Unique ID for rules.  When adding a new rule, do not specify this property. The Server will assign the key.  | [optional] 
**Status** | **ManagedEntityStatusEnum** | Flag to indicate whether or not the rule is currently satisfied.  | [optional] 
**Enabled** | **bool** | Flag to indicate whether or not the rule is enabled.  Set this property when you configure the rule. The default value is false (disabled). If there is a rule conflict, the Server can override the setting to disable a rule.  | [optional] 
**Name** | **string** | Name of the rule.  | [optional] 
**Mandatory** | **bool** | Flag to indicate whether compliance with this rule is mandatory or optional.  The default value is false (optional). - A mandatory rule will prevent a virtual machine from being powered on   or migrated to a host that does not satisfy the rule. - An optional rule specifies a preference. DRS takes an optional rule   into consideration when it places a virtual machine in the cluster.   DRS will act on an optional rule as long as it does not impact   the ability of the host to satisfy current CPU or memory requirements   for virtual machines on the system. (As long as the operation does not   cause any host to be more than 100% utilized.)  | [optional] 
**UserCreated** | **bool** | Flag to indicate whether the rule is created by the user or the system.  | [optional] 
**InCompliance** | **bool** | Flag to indicate whether or not the placement of Virtual Machines is currently in compliance with this rule.  The Server does not currently use this property.  | [optional] 
**RuleUuid** | **string** | UUID for the rule.  When adding a new rule, do not specify this property. The Server will assign the key.  | [optional] 
**VmGroupName** | **string** | Virtual group name (*ClusterVmGroup*.*ClusterGroupInfo.name*).  The virtual group may contain one or more virtual machines.  | [optional] 
**AffineHostGroupName** | **string** | Name of the affine host group (*ClusterHostGroup*.*ClusterGroupInfo.name*).  The affine host group identifies hosts on which *ClusterVmHostRuleInfo.vmGroupName* virtual machines can be powered-on. The value of the *ClusterRuleInfo.mandatory* property determines how the Server interprets the rule.  | [optional] 
**AntiAffineHostGroupName** | **string** | Name of the anti-affine host group (*ClusterHostGroup*.*ClusterGroupInfo.name*).  The anti-affine host group identifies hosts on which *ClusterVmHostRuleInfo.vmGroupName* virtual machines should not be powered-on. The value of the *ClusterRuleInfo.mandatory* property determines how the Server interprets the rule.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

