/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class AmortizingFixedRateBond extends Bond {
  private transient long swigCPtr;

  protected AmortizingFixedRateBond(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.AmortizingFixedRateBond_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(AmortizingFixedRateBond obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_AmortizingFixedRateBond(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public AmortizingFixedRateBond(int settlementDays, DoubleVector notionals, Schedule schedule, DoubleVector coupons, DayCounter accrualDayCounter, BusinessDayConvention paymentConvention, Date issueDate) {
    this(QuantLibJNI.new_AmortizingFixedRateBond__SWIG_0(settlementDays, DoubleVector.getCPtr(notionals), notionals, Schedule.getCPtr(schedule), schedule, DoubleVector.getCPtr(coupons), coupons, DayCounter.getCPtr(accrualDayCounter), accrualDayCounter, paymentConvention.swigValue(), Date.getCPtr(issueDate), issueDate), true);
  }

  public AmortizingFixedRateBond(int settlementDays, DoubleVector notionals, Schedule schedule, DoubleVector coupons, DayCounter accrualDayCounter, BusinessDayConvention paymentConvention) {
    this(QuantLibJNI.new_AmortizingFixedRateBond__SWIG_1(settlementDays, DoubleVector.getCPtr(notionals), notionals, Schedule.getCPtr(schedule), schedule, DoubleVector.getCPtr(coupons), coupons, DayCounter.getCPtr(accrualDayCounter), accrualDayCounter, paymentConvention.swigValue()), true);
  }

  public AmortizingFixedRateBond(int settlementDays, DoubleVector notionals, Schedule schedule, DoubleVector coupons, DayCounter accrualDayCounter) {
    this(QuantLibJNI.new_AmortizingFixedRateBond__SWIG_2(settlementDays, DoubleVector.getCPtr(notionals), notionals, Schedule.getCPtr(schedule), schedule, DoubleVector.getCPtr(coupons), coupons, DayCounter.getCPtr(accrualDayCounter), accrualDayCounter), true);
  }

  public AmortizingFixedRateBond(int settlementDays, Calendar paymentCalendar, double faceAmount, Date startDate, Period bondTenor, Frequency sinkingFrequency, double coupon, DayCounter accrualDayCounter, BusinessDayConvention paymentConvention, Date issueDate) {
    this(QuantLibJNI.new_AmortizingFixedRateBond__SWIG_3(settlementDays, Calendar.getCPtr(paymentCalendar), paymentCalendar, faceAmount, Date.getCPtr(startDate), startDate, Period.getCPtr(bondTenor), bondTenor, sinkingFrequency.swigValue(), coupon, DayCounter.getCPtr(accrualDayCounter), accrualDayCounter, paymentConvention.swigValue(), Date.getCPtr(issueDate), issueDate), true);
  }

  public AmortizingFixedRateBond(int settlementDays, Calendar paymentCalendar, double faceAmount, Date startDate, Period bondTenor, Frequency sinkingFrequency, double coupon, DayCounter accrualDayCounter, BusinessDayConvention paymentConvention) {
    this(QuantLibJNI.new_AmortizingFixedRateBond__SWIG_4(settlementDays, Calendar.getCPtr(paymentCalendar), paymentCalendar, faceAmount, Date.getCPtr(startDate), startDate, Period.getCPtr(bondTenor), bondTenor, sinkingFrequency.swigValue(), coupon, DayCounter.getCPtr(accrualDayCounter), accrualDayCounter, paymentConvention.swigValue()), true);
  }

  public AmortizingFixedRateBond(int settlementDays, Calendar paymentCalendar, double faceAmount, Date startDate, Period bondTenor, Frequency sinkingFrequency, double coupon, DayCounter accrualDayCounter) {
    this(QuantLibJNI.new_AmortizingFixedRateBond__SWIG_5(settlementDays, Calendar.getCPtr(paymentCalendar), paymentCalendar, faceAmount, Date.getCPtr(startDate), startDate, Period.getCPtr(bondTenor), bondTenor, sinkingFrequency.swigValue(), coupon, DayCounter.getCPtr(accrualDayCounter), accrualDayCounter), true);
  }

  public Frequency frequency() {
    return Frequency.swigToEnum(QuantLibJNI.AmortizingFixedRateBond_frequency(swigCPtr, this));
  }

  public DayCounter dayCounter() {
    return new DayCounter(QuantLibJNI.AmortizingFixedRateBond_dayCounter(swigCPtr, this), true);
  }

}
