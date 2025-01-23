# Homework 1

## P1
Consider an application that transmits data at a steady rate (for example, the sender generates an N-bit unit of data every k time units, where k is small and fixed). Also, when such an application starts, it will continue running for a relatively long period of time. Answer the following questions, briefly justifying your answer:

#### a. Would a packet-switched network or a circuit-switched network be more appropriate for this application? Why?

A circuit-switched network would be more appropriate for this application. This is because the application transmits data at a steady rate and runs for a long period of time. Circuit-switched networks establish a dedicated path between the sender and receiver for the duration of the communication, ensuring a constant data rate and minimal delay, which is ideal for steady and long-term data transmission.

#### b. Suppose that a packet-switched network is used and the only traffic in this network comes from such applications as described above. Furthermore, assume that the sum of the application data rates is less than the capacities of each and every link. Is some form of congestion control needed? Why? 
 
No, some form of congestion control is not needed in this scenario. Since the sum of the application data rates is less than the capacities of each and every link, there will be no congestion in the network. Congestion control is typically required when the network is overloaded with data, leading to packet loss and delays. However, in this case, the network capacity is sufficient to handle the data rates of all applications, so congestion control is unnecessary.

## P2
This elementary problem begins to explore propagation delay and transmission delay,
two central concepts in data networking. Consider two hosts, A and B, connected by a single link of
rate R bps. Suppose that the two hosts are separated by m meters, and suppose the propagation speed
along the link is s meters/sec. Host A is to send a packet of size L bits to Host B.

#### a. Express the propagation delay, d<sub>prop</sub>, in terms of *m* and *s*. 

The propagation delay, <code>d<sub>prop</sub></code>, is given by the distance between the hosts divided by the propagation speed:
<code>d<sub>prop</sub> = m/s</code>

#### b. Determine the transmission time of the packet, d<sub>trans</sub>, in terms of *L* and *R*.

The transmission time, <code>d<sub>trans</sub></code>, is given by the size of the packet divided by the transmission rate:
<code>d<sub>trans</sub> = L/R</code>

#### c. Ignoring processing and queuing delays, obtain an expression for the end-to-end delay.

The end-to-end delay is the sum of the propagation delay and the transmission delay:
<code>End-to-end delay = d<sub>prop</sub> + d<sub>trans</sub> = m/s + L/R</code>

#### d. Suppose Host A begins to transmit the packet at time t = 0. At time t = d<sub>trans</sub>, where is the last bit of the packet?

At time <code>t = d<sub>trans</sub></code>, the last bit of the packet has just been fully transmitted by Host A and is about to start propagating through the link.

#### e. Suppose d<sub>prop</sub> is greater than d<sub>trans</sub>. At time t = d<sub>trans</sub>, where is the first bit of the packet?

If <code>d<sub>prop</sub></code> is greater than <code>d<sub>trans</sub></code>, at time <code>t = d<sub>trans</sub></code>, the first bit of the packet is still propagating through the link and has not yet reached Host B. Specifically, it is at a distance <code>s * d<sub>trans</sub></code> from Host A.

#### f. Suppose <code>s = 2.5 x 10<sup>8</sup></code>, <code>L = 120</code> bits, <code>R = 56</code> kbps, and <code>m = 3000</code> km. Find the values of d<sub>prop</sub> and d<sub>trans</sub>.

Given:
- <code>s = 2.5 x 10<sup>8</sup></code> meters/second
- <code>L = 120</code> bits
- <code>R = 56 x 10<sup>3</sup></code> bits/second
- <code>m = 3000 x 10<sup>3</sup></code> meters

<code>d<sub>prop</sub> = m/s = 3000 x 10<sup>3</sup> / 2.5 x 10<sup>8</sup> = 0.012 seconds</code>

<code>d<sub>trans</sub> = L/R = 120 / 56 x 10<sup>3</sup> = 0.00214 seconds</code>

#### g. Suppose <code>s = 2.5 x 10<sup>8</sup></code>, <code>L = 1000</code> bits, <code>R = 1 x 10<sup>6</sup></code> bits/second, and <code>m = 2500 x 10<sup>3</sup></code> meters. Find the values of d<sub>prop</sub> and d<sub>trans</sub>.

Given:
- <code>s = 2.5 x 10<sup>8</sup></code> meters/second
- <code>L = 1000</code> bits
- <code>R = 1 x 10<sup>6</sup></code> bits/second
- <code>m = 2500 x 10<sup>3</sup></code> meters

<code>d<sub>prop</sub> = m/s = 2500 x 10<sup>3</sup> / 2.5 x 10<sup>8</sup> = 0.01 seconds</code>

<code>d<sub>trans</sub> = L/R = 1000 / 1 x 10<sup>6</sup> = 0.001 seconds</code>

## P3
In this problem, we consider sending real-time voice from Host A to Host B over a packet-switched network (VoIP). Host A converts analog voice to a digital 64 kbps bit stream on the fly. Host A then groups the bits into 56-byte packets. There is one link between Hosts A and B; its transmission rate is 10 Mbps and its propagation delay is 10 msec. As soon as Host A gathers a packet, it sends it to Host B. As soon as Host B receives an entire packet, it converts the packet’s bits to an
analog signal. How much time elapses from the time a bit is created (from the original analog signal at Host A) until the bit is decoded (as part of the analog signal at Host B)?

#### Answer:
1. **Packetization Delay**: 
   - Bit rate = 64 kbps = 64,000 bits per second
   - Packet size = 56 bytes = 56 * 8 = 448 bits
   - Packetization delay = Packet size / Bit rate = 448 bits / 64,000 bits per second = 0.007 seconds = 7 milliseconds

2. **Transmission Delay**:
   - Transmission rate = 10 Mbps = 10,000,000 bits per second
   - Transmission delay = Packet size / Transmission rate = 448 bits / 10,000,000 bits per second = 0.0000448 seconds = 0.0448 milliseconds

3. **Propagation Delay**:
   - Given propagation delay = 10 milliseconds

4. **Total Delay**:
   - Total delay = Packetization delay + Transmission delay + Propagation delay
   - Total delay = 7 milliseconds + 0.0448 milliseconds + 10 milliseconds = 17.0448 milliseconds

So, the total time elapsed from the time a bit is created until it is decoded is approximately **17.0448 milliseconds**.

## P4
A packet switch receives a packet and determines the outbound link to which the packet should be forwarded. When the packet arrives, one other packet is halfway done being transmitted on this outbound link and four other packets are waiting to be transmitted. Packets are transmitted in order of arrival. Suppose all packets are 1,500 bytes and the link rate is 2.5 Mbps. What is the queuing delay for the packet?

#### Answer:
1. **Packet Size**:
   - Packet size = 1,500 bytes = 1,500 * 8 = 12,000 bits

2. **Link Rate**:
   - Link rate = 2.5 Mbps = 2,500,000 bits per second

3. **Transmission Time for One Packet**:
   - Transmission time = Packet size / Link rate = 12,000 bits / 2,500,000 bits per second = 0.0048 seconds = 4.8 milliseconds

4. **Queuing Delay**:
   - There are four packets waiting to be transmitted and one packet halfway done being transmitted.
   - Total queuing delay = 4.5 * Transmission time = 4.5 * 4.8 milliseconds = 21.6 milliseconds

So, the queuing delay for the packet is **21.6 milliseconds**.

## P5
Consider a scenario where the transmission rate of the link between Host A and Host B is doubled to 20 Mbps. How does this change the total time elapsed from the time a bit is created until it is decoded in P3?

#### Answer:
1. **New Transmission Rate**:
   - New transmission rate = 20 Mbps = 20,000,000 bits per second

2. **New Transmission Delay**:
   - Transmission delay = Packet size / New transmission rate = 448 bits / 20,000,000 bits per second = 0.0000224 seconds = 0.0224 milliseconds

3. **Total Delay with New Transmission Rate**:
   - Total delay = Packetization delay + New transmission delay + Propagation delay
   - Total delay = 7 milliseconds + 0.0224 milliseconds + 10 milliseconds = 17.0224 milliseconds

So, with the transmission rate doubled to 20 Mbps, the total time elapsed from the time a bit is created until it is decoded is approximately **17.0224 milliseconds**.
