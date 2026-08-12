# Vcenter.ViJson.OpenApi.Model.VMwareVspanPort

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortKey** | **List&lt;string&gt;** | Individual ports to participate in the Distributed Port Mirroring session.  | [optional] 
**UplinkPortName** | **List&lt;string&gt;** | Uplink ports used as destination ports to participate in the Distributed Port Mirroring session.  A fault will be raised if uplinkPortName is used as source ports in any Distributed Port Mirroring session.  | [optional] 
**WildcardPortConnecteeType** | **List&lt;string&gt;** | Wild card specification for source ports participating in the Distributed Port Mirroring session.  See *DistributedVirtualSwitchPortConnecteeConnecteeType_enum* for valid values. Any port that has a connectee of the specified type has its receive traffic mirrored. A fault will be raised if wildcards are specified as destination ports or source ports mirroring traffic on the transmit side. It is to be not used.  | [optional] 
**Vlans** | **List&lt;int&gt;** | Vlan Ids for ingress source of Remote Mirror destination session.  | [optional] 
**IpAddress** | **List&lt;string&gt;** | IP address for the destination of encapsulated remote mirror source session, IPv4 address is specified using dotted decimal notation.  For example, \&quot;192.0.2.1\&quot;. IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits. A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

