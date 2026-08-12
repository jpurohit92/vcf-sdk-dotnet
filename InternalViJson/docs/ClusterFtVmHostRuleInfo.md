# Vcenter.ViJson.OpenApi.Model.ClusterFtVmHostRuleInfo

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
**VmGroupName** | **string** | Virtual machine group name (*ClusterVmGroup*.*ClusterGroupInfo.name*).  The named virtual machine group may have zero or more VMs. A virtual machine in this group may be a normal virtual machine or a fault tolerant primary virtual machine; it cannot be a fault tolerant secondary virtual machine.  Control of FT secondary virtual machines is implied by the presence of the primary FT virtual machine.  A virtual machine in this group should not be referenced in any other FT VM-Host rule or VM-Host rule *ClusterVmHostRuleInfo*.  | 
**HostGroupName** | **List&lt;string&gt;** | Array of two Host Groups (*ClusterHostGroup*).  The hostGroup array must have two host groups. Each host group in the hostGroup array will have a set of hosts. For each Fault Tolerance primary VM that is part of VmGroup, the primary and secondary VMs would be placed on hosts that are not part of the same host group.  The members of each host group should be disjoint from the members of all other host group specified.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

