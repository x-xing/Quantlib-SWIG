/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class Forward extends Instrument {
  private transient long swigCPtr;

  protected Forward(long cPtr, boolean cMemoryOwn) {
    super(QuantLibJNI.Forward_SWIGUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(Forward obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_Forward(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public double forwardValue() {
    return QuantLibJNI.Forward_forwardValue(swigCPtr, this);
  }

  public InterestRate impliedYield(double underlyingSpotValue, double forwardValue, Date settlementDate, Compounding compoundingConvention, DayCounter dayCounter) {
    return new InterestRate(QuantLibJNI.Forward_impliedYield(swigCPtr, this, underlyingSpotValue, forwardValue, Date.getCPtr(settlementDate), settlementDate, compoundingConvention.swigValue(), DayCounter.getCPtr(dayCounter), dayCounter), true);
  }

  public Forward() {
    this(QuantLibJNI.new_Forward(), true);
  }

}