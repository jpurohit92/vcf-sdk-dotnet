# Vcenter.ViJson.OpenApi.Model.VMwareVspanSession

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The generated key as the identifier for the session.  | [optional] 
**Name** | **string** | The display name.  | [optional] 
**Description** | **string** | The description for the session.  | [optional] 
**Enabled** | **bool** | Whether the session is enabled.  | 
**SourcePortTransmitted** | [**VMwareVspanPort**](VMwareVspanPort.md) | Source ports for which transmitted packets are mirrored.  | [optional] 
**SourcePortReceived** | [**VMwareVspanPort**](VMwareVspanPort.md) | Source ports for which received packets are mirrored.  | [optional] 
**DestinationPort** | [**VMwareVspanPort**](VMwareVspanPort.md) | Destination ports that received the mirrored packets.  You cannot use wild card ports as destination ports. If *VMwareVspanPort.wildcardPortConnecteeType* is set in the value, the reconfigure operation will raise a fault. Also any port designated in the value of this property can not match the wild card source port in any of the Distributed Port Mirroring session.  | [optional] 
**EncapsulationVlanId** | **int** | VLAN ID used to encapsulate the mirrored traffic.  | [optional] 
**StripOriginalVlan** | **bool** | Whether to strip the original VLAN tag.  if false, the original VLAN tag will be preserved on the mirrored traffic. If *VMwareVspanSession.encapsulationVlanId* has been set and this property is false, the frames will be double tagged with the original VLAN ID as the inner tag.  | 
**MirroredPacketLength** | **int** | An integer that describes how much of each frame to mirror.  If unset, all of the frame would be mirrored. Setting this property to a smaller value is useful when the consumer will look only at the headers. The value cannot be less than 60.  | [optional] 
**NormalTrafficAllowed** | **bool** | Whether or not destination ports can send and receive \&quot;normal\&quot; traffic.  Setting this to false will make mirror ports be used solely for mirroring and not double as normal access ports.  | 
**SessionType** | **string** | Type of the session.  See *VMwareDVSVspanSessionType_enum* for valid values. Default value is mixedDestMirror if unspecified in a VSPAN create operation.  | [optional] 
**SamplingRate** | **int** | Sampling rate of the session.  If its value is n, one of every n packets is mirrored. Valid values are between 1 to 65535, and default value is 1.  | [optional] 
**EncapType** | **string** | Encapsulation type of the session.  See *VMwareDVSVspanSessionEncapType_enum* for valid values. Default value is encapProtocolGRE if unspecified in a VSPAN create operation.  | [optional] 
**ErspanId** | **int** | ERSPAN ID of the session.  Valid values are between 0 to 0x3ff, and default value is 0. This value is applicable only if encaptType is *erspan2* or *erspan3*  | [optional] 
**ErspanCOS** | **int** | Class of Service of the monitored frame.  Valid values are between 0 to 7, and default value is 0. This value is applicable only if encaptType is *erspan2* or *erspan3*  | [optional] 
**ErspanGraNanosec** | **bool** | Timestamp Granularity.  If the value is false, timestamp-granularity will be microsecond. Otherwise the timestamp-granularity will be nanosecond This value is applicable only if encaptType is *erspan3*  | [optional] 
**Netstack** | **string** | Netstack instance of the session.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

