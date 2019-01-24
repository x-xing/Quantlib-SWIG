/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class MakeSchedule {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected MakeSchedule(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MakeSchedule obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_MakeSchedule(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public MakeSchedule() {
    this(QuantLibJNI.new_MakeSchedule(), true);
  }

  public MakeSchedule from(Date effectiveDate) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_from(swigCPtr, this, Date.getCPtr(effectiveDate), effectiveDate), false);
  }

  public MakeSchedule to(Date terminationDate) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_to(swigCPtr, this, Date.getCPtr(terminationDate), terminationDate), false);
  }

  public MakeSchedule withTenor(Period arg0) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withTenor(swigCPtr, this, Period.getCPtr(arg0), arg0), false);
  }

  public MakeSchedule withFrequency(Frequency arg0) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withFrequency(swigCPtr, this, arg0.swigValue()), false);
  }

  public MakeSchedule withCalendar(Calendar arg0) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withCalendar(swigCPtr, this, Calendar.getCPtr(arg0), arg0), false);
  }

  public MakeSchedule withConvention(BusinessDayConvention arg0) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withConvention(swigCPtr, this, arg0.swigValue()), false);
  }

  public MakeSchedule withTerminationDateConvention(BusinessDayConvention arg0) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withTerminationDateConvention(swigCPtr, this, arg0.swigValue()), false);
  }

  public MakeSchedule withRule(DateGeneration.Rule arg0) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withRule(swigCPtr, this, arg0.swigValue()), false);
  }

  public MakeSchedule forwards() {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_forwards(swigCPtr, this), false);
  }

  public MakeSchedule backwards() {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_backwards(swigCPtr, this), false);
  }

  public MakeSchedule endOfMonth(boolean flag) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_endOfMonth__SWIG_0(swigCPtr, this, flag), false);
  }

  public MakeSchedule endOfMonth() {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_endOfMonth__SWIG_1(swigCPtr, this), false);
  }

  public MakeSchedule withFirstDate(Date d) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withFirstDate(swigCPtr, this, Date.getCPtr(d), d), false);
  }

  public MakeSchedule withNextToLastDate(Date d) {
    return new MakeSchedule(QuantLibJNI.MakeSchedule_withNextToLastDate(swigCPtr, this, Date.getCPtr(d), d), false);
  }

  public Schedule schedule() {
    return new Schedule(QuantLibJNI.MakeSchedule_schedule(swigCPtr, this), true);
  }

}
