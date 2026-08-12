# Vcenter.ViJson.OpenApi.Model.EventAlarmExpression

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comparisons** | [**List&lt;EventAlarmExpressionComparison&gt;**](EventAlarmExpressionComparison.md) | The attributes/values to compare.  | [optional] 
**EventType** | **string** | Deprecated use &lt;code&gt;eventTypeId&lt;/code&gt; instead.  The type of the event to trigger the alarm on.  | 
**EventTypeId** | **string** | The eventTypeId of the event to match.  The semantics of how eventTypeId matching is done is as follows: - If the event being matched is of type *EventEx*   or *ExtendedEvent*, then we match this value   against the &lt;code&gt;eventTypeId&lt;/code&gt; (for &lt;code&gt;EventEx&lt;/code&gt;) or   &lt;code&gt;eventId&lt;/code&gt; (for &lt;code&gt;ExtendedEvent&lt;/code&gt;) member of the Event. - Otherwise, we match it against the type of the Event itself.    Either &lt;code&gt;eventType&lt;/code&gt; or &lt;code&gt;eventTypeId&lt;/code&gt; _must_ be set.  | [optional] 
**ObjectType** | **string** | Name of the type of managed object on which the event is logged.  An event alarm defined on a *ManagedEntity* is propagated to child entities in the VirtualCenter inventory depending on the value of this attribute. If objectType is any of the following, the alarm is propagated down to all children of that type: - A datacenter: *Datacenter*. - A cluster of host systems: *ClusterComputeResource*. - A single host system: *HostSystem*. - A resource pool representing a set of physical resources on a single host:   *ResourcePool*. - A virtual machine: *VirtualMachine*. - A datastore: *Datastore*. - A network: *Network*. - A distributed virtual switch: *DistributedVirtualSwitch*.    If objectType is unspecified or not contained in the above list, the event alarm is not propagated down to child entities in the VirtualCenter inventory.  It is possible to specify an event alarm containing two (or more) different EventAlarmExpression&#39;s which contain different objectTypes. In such a case, the event is propagated to all child entities with specified type(s).  | [optional] 
**Status** | **ManagedEntityStatusEnum** | The alarm&#39;s new state when this condition is evaluated and satisfied.  If not specified then there is no change to alarm status, and all actions are fired (rather than those for the transition).  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

